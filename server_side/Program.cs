using Swashbuckle.AspNetCore;   // for Swagger
using Microsoft.OpenApi.Models; // for Swagger
using Microsoft.AspNetCore.Identity;
using CoffeeShopApi.Models.DAL;
using CoffeeShopApi.Models.DomainModels;
using Microsoft.EntityFrameworkCore;
using CoffeeShopApi.Services.Interfaces;
using CoffeeShopApi.Services.Implements;
using System.Text;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using CoffeeShopApi.Repositories.Interfaces;
using CoffeeShopApi.Repositories.Implements;    // for .UseSqlServer()


// $ dotnet add package Newtonsoft.Json --version 13.0.3
// $ dotnet add package Microsoft.OpenApi --version 1.6.14
// $ dotnet add package Swashbuckle.AspNetCore --version 6.5.0
// $ dotnet add package Microsoft.EntityFrameworkCore --version 6.0.28
// $ dotnet add package Microsoft.EntityFrameworkCore.Relational --version 6.0.28
// $ dotnet add package Microsoft.EntityFrameworkCore.Design --version 6.0.28
// $ dotnet add package Microsoft.EntityFrameworkCore.SqlServer --version 6.0.28
// $ dotnet add package Microsoft.EntityFrameworkCore.Tools --version 6.0.28
// $ dotnet add package Microsoft.AspNetCore.Identity.EntityFrameworkCore --version 6.0.28
// $ dotnet add package Microsoft.AspNetCore.Identity.UI --version 6.0.27
// $ dotnet add package Microsoft.AspNetCore.Authentication.JwtBearer --version 6.0.28
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
#region Services injection
builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();
builder.Services.AddScoped<IAuthTokenService, AuthTokenService>();
builder.Services.AddScoped<IAuthService, AuthService>();
builder.Services.AddScoped<IOrderService, OrderService>();
builder.Services.AddScoped<IDrinkTypeService, DrinkTypeService>();
builder.Services.AddScoped<IDrinkService, DrinkService>();
builder.Services.AddScoped<IVoucherCodeService, VoucherCodeService>();
#endregion

#region Controllers:
builder.Services.AddControllers();
#endregion

#region SwaggerUI:
// Add Swagger UI for api debugging:
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo
    {
        Version = "v1",
        Title = "CoffeeShop .NET Backend",
        Description = "Tunghayho AspNetCore6.0 JIT Build",
        TermsOfService = new Uri("https://example.com/terms"),
        License = new OpenApiLicense
        {
            Name = "Use under LICX",
            Url = new Uri("https://example.com/license"),
        }
    });
    // Configuring Swagger UI Authorization with Swagger
    #region Accepting Bearer Token:
    // tutorial: https://code-maze.com/swagger-authorization-aspnet-core
    c.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
    {
        In = ParameterLocation.Header,
        Description = "Please enter token",
        Name = "Authorization",
        Type = SecuritySchemeType.Http,
        BearerFormat = "JWT",
        Scheme = "bearer"
    });
    c.AddSecurityRequirement(new OpenApiSecurityRequirement
    {
            {
                new OpenApiSecurityScheme
                {
                     Reference = new OpenApiReference
                     {
                         Type=ReferenceType.SecurityScheme,
                         Id="Bearer"
                     }
                },
                new string[]{}
            }
    });
    // End of Configuring Authorization with Swagger UI to accept bearerJWT
    #endregion
});
#endregion


#region DbContext & Identity Auth:
var connectionString = builder.Configuration.GetConnectionString("MSSQLConnection") ?? throw new InvalidOperationException("Connection string 'MSSQLConnection' not found!");
builder.Services.AddDbContext<AppDbContext>(options =>
     options.UseSqlServer(connectionString)); // (Microsoft.EntityFrameworkCore.SqlServer)

// to use 'AddDefaultIdentity': install package 'Microsoft.AspNetCore.Identity.UI' !!! NET 7
builder.Services.AddDefaultIdentity<ApplicationUser>()
    .AddRoles<IdentityRole>()
    .AddEntityFrameworkStores<AppDbContext>();

    // #region Email Confirmation (1) (using EmailService;)
    // .AddTokenProvider<EmailConfirmationTokenProvider<ApplicationUser>>("emailconfirmation");
#endregion


#region LocalStorage Jwt Authentication:

var key = Encoding.UTF8.GetBytes(builder.Configuration["ApplicationSettings:JWT_Secret"]); //from appsettings.json

// @Warning: if use Cookie to authenticate private endpoints, disable these line below
// cuz ASP.NET Core can only use ONE auth scheme (LocalSotrage or Cookie) only!!! 

builder.Services.AddAuthentication(x =>
{
    x.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
    x.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
    x.DefaultScheme = JwtBearerDefaults.AuthenticationScheme;
}).AddJwtBearer(x =>
{
    x.RequireHttpsMetadata = false;
    x.SaveToken = false;
    x.TokenValidationParameters = new Microsoft.IdentityModel.Tokens.TokenValidationParameters
    {
        ValidateIssuerSigningKey = true,
        IssuerSigningKey = new SymmetricSecurityKey(key),
        ValidateIssuer = false,
        ValidIssuer = "https://localhost:5146", //some string, normally web url,  
        ValidateAudience = false,
        ClockSkew = TimeSpan.Zero
    };
});
#endregion

#region CORS
builder.Services.AddCors(policy => {
    policy.AddPolicy("defaultPolicy", options => {
        options.AllowAnyHeader();
        options.AllowAnyMethod();
        options.AllowAnyOrigin();

    });
});
#endregion


var app = builder.Build();


#region "use cors & swaggerUI"
// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    // Use Swagger UI to debug API: (https://localhost:{PORT}/swagger) // PORT is in launchSettings / "applicationUrl"
    app.UseSwagger();
    app.UseSwaggerUI(c =>
    {
        c.SwaggerEndpoint("/swagger/v1/swagger.json", "Tunghayho AspNetCore 6.0 WebApi JIT build");
        c.InjectStylesheet("/swagger-custom/swagger-custom-styles.css");  //Added Code for custom Swagger theme (pref: https://blog.rashik.com.np/customize-swagger-ui-with-custom-logo-and-theme-color)
        c.InjectJavascript("/swagger-custom/swagger-custom-script.js", "text/javascript");  //Added Code for custom Swagger theme
    });

    app.UseDeveloperExceptionPage();
}
app.UseCors(CorsBuilder =>
{
    CorsBuilder
       //.AllowAnyOrigin()  // .net doesnt allow 'AllowAnyOrigin' together with 'AllowCredentials'
       .WithOrigins("http://localhost:3000", "http://192.168.1.1:3000", "http://localhost:5173") // set your ClientApp origins here !!
       .SetIsOriginAllowedToAllowWildcardSubdomains()
       .AllowAnyHeader()
       .AllowCredentials()
       .WithMethods("GET", "PUT", "POST", "DELETE", "OPTIONS")
       .SetPreflightMaxAge(TimeSpan.FromSeconds(3600)); // TimeSpan.FromMinutes(60)
});
#endregion





app.UseAuthentication();
app.UseAuthorization();

app.UseHttpsRedirection();

app.MapControllers();

app.Run();

