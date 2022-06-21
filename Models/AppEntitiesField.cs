using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class AppEntitiesField
    {
        public int Id { get; set; }
        public decimal IdEntity { get; set; }
        public string FieldName { get; set; } = null!;
        public string? PresentationName { get; set; }
        public string? FormulaVb { get; set; }
        public string? FormulaFormat { get; set; }
        public string? FormulaSql { get; set; }
        public string? CreateFuncCode { get; set; }
        public string? CodeRecord { get; set; }
    }
}
