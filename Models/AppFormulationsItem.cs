using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class AppFormulationsItem
    {
        public int Id { get; set; }
        public int IdFormulationType { get; set; }
        public string Name { get; set; } = null!;
        public string NameNormalized { get; set; } = null!;
        public string NamePresentation { get; set; } = null!;
        public string FormDescription { get; set; } = null!;
        public string? FormParameters { get; set; }
        public string ZeusScript { get; set; } = null!;
        public string CategoryPath { get; set; } = null!;
        public string TypeData { get; set; } = null!;
        public decimal? Size { get; set; }
        public string SqlScript { get; set; } = null!;
        public object? DefaultValue { get; set; }
        public int FormOrder { get; set; }
    }
}
