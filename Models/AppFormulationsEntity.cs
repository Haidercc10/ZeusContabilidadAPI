using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class AppFormulationsEntity
    {
        public int Id { get; set; }
        public int IdEntity { get; set; }
        public string Name { get; set; } = null!;
        public string? DescriptionForm { get; set; }
        public string FormulaZeusScript { get; set; } = null!;
        public string FormulaSql { get; set; } = null!;
    }
}
