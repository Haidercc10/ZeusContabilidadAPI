using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class AspNetPrivilege
    {
        public int Id { get; set; }
        public string Code { get; set; } = null!;
        public string Name { get; set; } = null!;
        public string? Description { get; set; }
        public string Controller { get; set; } = null!;
        public string Action { get; set; } = null!;
        public bool IsAccessByRecord { get; set; }
        public int? IdEntity { get; set; }
        public string? IdMenuParent { get; set; }
        public string? IdMenu { get; set; }
        public int? Orden { get; set; }
        public bool? IsFather { get; set; }
    }
}
