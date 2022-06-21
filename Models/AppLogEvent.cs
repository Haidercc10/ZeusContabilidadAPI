using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class AppLogEvent
    {
        public string Code { get; set; } = null!;
        public string CodeTypeEvent { get; set; } = null!;
        public string? Name { get; set; }
        public string? Description { get; set; }
        public string? Aplication { get; set; }
        public bool Disable { get; set; }
        public string Entity { get; set; } = null!;
        public string Action { get; set; } = null!;
    }
}
