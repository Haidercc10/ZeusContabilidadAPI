using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class AppEntitiesSelector
    {
        public int Id { get; set; }
        public int IdEntityType { get; set; }
        public string Name { get; set; } = null!;
        public string SqlSelect { get; set; } = null!;
    }
}
