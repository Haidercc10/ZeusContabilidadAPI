using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class AppDesignVariablesItem
    {
        public int Id { get; set; }
        public int IdEntityType { get; set; }
        public int? IdEntity { get; set; }
        public string Type { get; set; } = null!;
        public string? ContainerName { get; set; }
        public string? GroupName { get; set; }
        public string? Description { get; set; }
    }
}
