using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class AppLogTypeEvent
    {
        public string Code { get; set; } = null!;
        public string? Name { get; set; }
        public string? Description { get; set; }
    }
}
