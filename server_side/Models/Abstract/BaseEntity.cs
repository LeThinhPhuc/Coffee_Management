namespace CoffeeShopApi.Models.Abstract
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public abstract class BaseEntity
    {
        public string Id { get; set; } = Guid.NewGuid().ToString();

        [Required]
        public DateTime DateCreated { get; set; } = GetCurrentTimeInDesiredTimeZone();  // DateTime.Now()

        [Required]
        public DateTime DateModified { get; set; } = GetCurrentTimeInDesiredTimeZone();


        private static DateTime GetCurrentTimeInDesiredTimeZone()
        {
            TimeZoneInfo desiredTimeZone = TimeZoneInfo.FindSystemTimeZoneById("SE Asia Standard Time"); // ((GMT+07:00) Bangkok, Hanoi, Jakarta)

            return TimeZoneInfo.ConvertTime(DateTime.Now, desiredTimeZone);
        }
    }
}
