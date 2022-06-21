using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class DianCodigosdeInformacion
    {
        public string Ano { get; set; } = null!;
        public string CodigodeInformacion { get; set; } = null!;
        public string Descripcion { get; set; } = null!;
        public string? PrimerValor { get; set; }
        public string? SegundoValor { get; set; }
        public string? TercerValor { get; set; }
        public string? TipodeDisenoE { get; set; }
        public string? TipodeDisenoc { get; set; }
        public int? Formato { get; set; }
        public int? Version { get; set; }
        public string? NodoE { get; set; }
        public string? NodoC { get; set; }
        public int IdenDiancodigosdeinformacion { get; set; }
    }
}
