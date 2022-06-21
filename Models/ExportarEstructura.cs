using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class ExportarEstructura
    {
        public string Campo { get; set; } = null!;
        public string? Definicion { get; set; }
        public byte Consolidado { get; set; }
        public string Expresion { get; set; } = null!;
        public string? ValorDefault { get; set; }
        public int Orden { get; set; }
        public byte ExcluirCampo { get; set; }
        public int? VariableDefault { get; set; }
        public string? Filtrohaving { get; set; }
        public string? ExpresionGrupo { get; set; }
        public int IdenExportarEstructura { get; set; }
    }
}
