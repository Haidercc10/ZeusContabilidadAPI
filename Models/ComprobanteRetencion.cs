using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class ComprobanteRetencion
    {
        public ComprobanteRetencion()
        {
            ComprobanteRetencionFacturas = new HashSet<ComprobanteRetencionFactura>();
        }

        public decimal Iden { get; set; }
        public decimal Codigo { get; set; }
        public string Fuente { get; set; } = null!;
        public string Documento { get; set; } = null!;
        public string FuenteEgreso { get; set; } = null!;
        public string DocumentoEgreso { get; set; } = null!;
        public string Cuenta { get; set; } = null!;
        public string Fecha { get; set; } = null!;
        public string Serie { get; set; } = null!;
        public string Observacion { get; set; } = null!;
        public string Estado { get; set; } = null!;
        public string Proveedor { get; set; } = null!;
        public string Tercero { get; set; } = null!;
        public string IdentificadorProv { get; set; } = null!;
        public string IdentificadorRete { get; set; } = null!;
        public string RegimenRete { get; set; } = null!;
        public string FechaEmision { get; set; } = null!;
        public decimal? TasaRetencion { get; set; }
        public decimal ImporteRetenido { get; set; }
        public decimal ImportePagado { get; set; }

        public virtual ICollection<ComprobanteRetencionFactura> ComprobanteRetencionFacturas { get; set; }
    }
}
