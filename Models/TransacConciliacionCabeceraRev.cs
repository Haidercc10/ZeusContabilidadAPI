using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class TransacConciliacionCabeceraRev
    {
        public decimal? Consecutivo { get; set; }
        public string? Fuente { get; set; }
        public string? Documento { get; set; }
        public string? Cuenta { get; set; }
        public string? Fecha { get; set; }
        public string? Item { get; set; }
        public string? Cenco { get; set; }
        public string? Propiedad1 { get; set; }
        public string? Propiedad2 { get; set; }
        public string? Propiedad3 { get; set; }
        public string? Propiedad4 { get; set; }
        public string? Propiedad5 { get; set; }
        public string? Tipofac { get; set; }
        public string? Numefac { get; set; }
        public string? Vencefac { get; set; }
        public string? Refefac { get; set; }
        public string? Entidad { get; set; }
        public string? Plaza { get; set; }
        public int IdenTransacConciliacionCabeceraRev { get; set; }
    }
}
