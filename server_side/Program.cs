using Swashbuckle.AspNetCore;   // for Swagger
using Microsoft.OpenApi.Models; // for Swagger
using Microsoft.AspNetCore.Identity;
using CoffeeShopApi.Models.DAL;
using CoffeeShopApi.Models.DomainModels;
using Microsoft.EntityFrameworkCore;
using CoffeeShopApi.DataAccess;    // for .UseSqlServer()


// $ dotnet add package Microsoft.OpenApi --version 1.6.14
// $ dotnet add package Swashbuckle.AspNetCore --version 6.5.0
// $ dotnet add package Microsoft.EntityFrameworkCore --version 6.0.28
// $ dotnet add package Microsoft.EntityFrameworkCore.Relational --version 6.0.28
// $ dotnet add package Microsoft.EntityFrameworkCore.Design --version 6.0.28
// $ dotnet add package Microsoft.EntityFrameworkCore.SqlServer --version 6.0.28
// $ dotnet add package Microsoft.EntityFrameworkCore.Tools --version 6.0.28
// $ dotnet add package Microsoft.AspNetCore.Identity.EntityFrameworkCore --version 6.0.28
// $ dotnet add package Microsoft.AspNetCore.Identity.UI --version 6.0.27
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddScoped<IOrderService,OrderService>();
builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies()); 

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
//var connectionString = builder.Configuration.GetConnectionString("DockerMSSQLConnection") ?? throw new InvalidOperationException("Connection string 'MSSQLConnection' not found!");
var connectionString = builder.Configuration.GetConnectionString("MSSQLConnection");
builder.Services.AddDbContext<AppDbContext>(options =>
     options.UseSqlServer(connectionString)); // (Microsoft.EntityFrameworkCore.SqlServer)

// to use 'AddDefaultIdentity': install package 'Microsoft.AspNetCore.Identity.UI' !!! NET 7
builder.Services.AddDefaultIdentity<ApplicationUser>()
    .AddRoles<IdentityRole>()
    .AddEntityFrameworkStores<AppDbContext>();

    // #region Email Confirmation (1) (using EmailService;)
    // .AddTokenProvider<EmailConfirmationTokenProvider<ApplicationUser>>("emailconfirmation");
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
// Put this "UseCors" before "UseMvc" or else it wont permit any Origins !
// this one UseCors code solve all the CORS issues !! (preference: https://briancaos.wordpress.com/2022/10/03/net-api-cors-response-to-preflight-request-doesnt-pass-access-control-check-no-access-control-allow-origin-header-net-api/)
// app.UseCors(CorsBuilder =>
// {
//     CorsBuilder
//        //.AllowAnyOrigin()  // .net doesnt allow 'AllowAnyOrigin' together with 'AllowCredentials'
//        .WithOrigins("http://localhost:44429", "https://localhost:44429", "http://localhost:19006") // set your ClientApp origins here !!
//        .SetIsOriginAllowedToAllowWildcardSubdomains()
//        .AllowAnyHeader()
//        .AllowCredentials()
//        .WithMethods("GET", "PUT", "POST", "DELETE", "OPTIONS")
//        .SetPreflightMaxAge(TimeSpan.FromSeconds(3600)); // TimeSpan.FromMinutes(60)
// });
#endregion



app.UseHttpsRedirection();


app.MapControllers();

app.Run();

