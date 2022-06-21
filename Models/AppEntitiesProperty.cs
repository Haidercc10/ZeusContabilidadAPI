using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class AppEntitiesProperty
    {
        public int Id { get; set; }
        public int IdEntity { get; set; }
        public string FieldName { get; set; } = null!;
        public string? PresentationName { get; set; }
    }
}
