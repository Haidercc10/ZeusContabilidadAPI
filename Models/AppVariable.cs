using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class AppVariable
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string NormalizedName { get; set; } = null!;
        public string? VarDescription { get; set; }
        public int IdTypeVar { get; set; }
        public int IdDataType { get; set; }
        public decimal? VarLength { get; set; }
        public decimal? Prec { get; set; }
        public string? DefaultvalueVarchar { get; set; }
        public decimal? DefaultvalueNumeric { get; set; }
        public int? DefaultvalueInt { get; set; }
        public DateTime? DefaultvalueDatetime { get; set; }
        public bool DefaultvalueBit { get; set; }
        public bool IsDisabled { get; set; }
        public bool UniqueGlobal { get; set; }
        public bool HandleHelp { get; set; }
        public int? IdHelpf4 { get; set; }
        public bool IsFormulated { get; set; }
        public string? DefaultFormula { get; set; }
        public DateTime CreationDate { get; set; }
        public string IdUserCreator { get; set; } = null!;
        public DateTime LastUpdate { get; set; }
        public string IdUserLastupdate { get; set; } = null!;
        public int? IdGroup { get; set; }
        public bool? IsSelection { get; set; }
        public int? OrderFormulaVarGlobal { get; set; }
    }
}
