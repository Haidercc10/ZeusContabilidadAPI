using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class AppParameter
    {
        public string Code { get; set; } = null!;
        public string Description { get; set; } = null!;
        public decimal? VarLength { get; set; }
        public decimal? Prec { get; set; }
        public string? ConditionSave { get; set; }
        public string? ValueStr { get; set; }
        public DateTime DateUpdate { get; set; }
        public string? IdUserSave { get; set; }
        public bool? IsEditable { get; set; }
        public int NumOrder { get; set; }
        public string? Detail { get; set; }
        public bool IsVisible { get; set; }
        public int Id { get; set; }
        public string? PathParentCode { get; set; }
        public bool? IsParent { get; set; }
        public int? IdDataType { get; set; }
        public string? Placeholder { get; set; }
        public bool? IsRequired { get; set; }
        public bool? IsPassword { get; set; }
        public string? ValueDefault { get; set; }
        public string? ValueSelect { get; set; }
        public string? CodeHelp { get; set; }
        public string? ConditionActive { get; set; }
        public bool? IsActive { get; set; }
        public string Tipo { get; set; } = null!;
        public string? Pariente { get; set; }
        public string? Descripcion { get; set; }
    }
}
