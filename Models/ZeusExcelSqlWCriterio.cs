using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class ZeusExcelSqlWCriterio
    {
        public int Id { get; set; }
        public int? SqlWQueryId { get; set; }
        public string? Tabla { get; set; }
        public string? AliasTabla { get; set; }
        public string? Campo { get; set; }
        public string? AliasCampo { get; set; }
        public bool Salida { get; set; }
        public int? Orden { get; set; }
        public string? TipoOrden { get; set; }

        public virtual ZeusExcelSqlWQuery? SqlWQuery { get; set; }
    }
}
