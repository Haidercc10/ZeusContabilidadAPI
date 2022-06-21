using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class AppDataType
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string Presentation { get; set; } = null!;
        public string? TypeDescription { get; set; }
        public string? Regex { get; set; }
    }
}
