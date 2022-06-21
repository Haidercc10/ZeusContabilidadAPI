using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class AppVariablesType
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public int? IdEntityType { get; set; }
    }
}
