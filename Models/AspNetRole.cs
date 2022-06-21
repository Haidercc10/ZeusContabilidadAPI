using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class AspNetRole
    {
        public string Id { get; set; } = null!;
        public string? Name { get; set; }
        public string? NormalizedName { get; set; }
        public string? ConcurrencyStamp { get; set; }
        public bool? IdBit { get; set; }
        public string? DescName { get; set; }
        public string? Description { get; set; }
    }
}
