using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class FacturaRcCodbar
    {
        public int? SpId { get; set; }
        public string? Bu { get; set; }
        public string? Codicta { get; set; }
        public string? Idcliprv { get; set; }
        public string? Tipofact { get; set; }
        public string? Numefac { get; set; }
        public string? Vencefac { get; set; }
        public string? Refefac { get; set; }
        public bool? SeleccionPrincipal { get; set; }
        public decimal? VrAplicar { get; set; }
        public int IdenFacturaRcCodbar { get; set; }
    }
}
