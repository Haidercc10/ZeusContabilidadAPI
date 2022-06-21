using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class VariableDefinicionFuncione
    {
        public decimal Iden { get; set; }
        public string Nombre { get; set; } = null!;
        public string Presentacion { get; set; } = null!;
        public string? Descripcion { get; set; }
        public string FormulaDefinida { get; set; } = null!;
        public string ValorDefault { get; set; } = null!;
        public bool FuncionDeAgregado { get; set; }
    }
}
