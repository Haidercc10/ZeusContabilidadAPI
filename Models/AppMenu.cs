using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class AppMenu
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string? DescriptionHelp { get; set; }
        public string? Controller { get; set; }
        public string? Action { get; set; }
        public int NumOrder { get; set; }
        public bool? IsActive { get; set; }
        public bool IsMenuParent { get; set; }
        public int? IdMenuParent { get; set; }
    }
}
