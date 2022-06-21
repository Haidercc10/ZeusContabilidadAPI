using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class AspNetUser
    {
        public string Id { get; set; } = null!;
        public string UserName { get; set; } = null!;
        public string? NormalizedUserName { get; set; }
        public string Email { get; set; } = null!;
        public string? NormalizedEmail { get; set; }
        public bool? EmailConfirmed { get; set; }
        public string? PasswordHash { get; set; }
        public string? SecurityStamp { get; set; }
        public string? ConcurrencyStamp { get; set; }
        public string? PhoneNumber { get; set; }
        public bool? PhoneNumberConfirmed { get; set; }
        public bool? TwoFactorEnabled { get; set; }
        public DateTimeOffset? LockoutEnd { get; set; }
        public bool? LockoutEnabled { get; set; }
        public int? AccessFailedCount { get; set; }
        public string? UrlPhoto { get; set; }
        public string? FullName { get; set; }
        public string? IdUserCreator { get; set; }
        public bool BlockLogin { get; set; }
        public bool BlockTemp { get; set; }
        public bool BlockAdmin { get; set; }
        public bool BlockSchedule { get; set; }
        public DateTime? BlockScheduleDate { get; set; }
    }
}
