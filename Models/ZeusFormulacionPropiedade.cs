using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class ZeusFormulacionPropiedade
    {
        public decimal Iden { get; set; }
        public string Nombre { get; set; } = null!;
        public string Descripcion { get; set; } = null!;
        public string Presentacion { get; set; } = null!;
        public string? Parametros { get; set; }
        public string Zvbscript { get; set; } = null!;
        public string Categoria { get; set; } = null!;
        public string TipoDato { get; set; } = null!;
        public decimal? Tamano { get; set; }
        public string? FnScriptControl { get; set; }
        public string Execsql { get; set; } = null!;
        public decimal? DefaultNumerico { get; set; }
        public string? DefaultVarchar { get; set; }
        public DateTime? DefaultFecha { get; set; }
        public int Orden { get; set; }
        public int QuitarEspacios { get; set; }
        public int IndEsquemaModuloExterno { get; set; }
    }
}
