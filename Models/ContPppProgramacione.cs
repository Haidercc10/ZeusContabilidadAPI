using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class ContPppProgramacione
    {
        public ContPppProgramacione()
        {
            ContPppProgramacionesFacturas = new HashSet<ContPppProgramacionesFactura>();
            ContPppProgramacionesPagos = new HashSet<ContPppProgramacionesPago>();
        }

        public decimal Iden { get; set; }
        public decimal Codigo { get; set; }
        public decimal IdenEstado { get; set; }
        public string Fecha { get; set; } = null!;
        public decimal? IdenMetodoPago { get; set; }
        public DateTime FechaGrabacion { get; set; }
        public string? Observaciones { get; set; }
        public string? Fuente { get; set; }
        public string? Documento { get; set; }
        public string? FechaComprobante { get; set; }
        public string? Item { get; set; }
        public string? DescripcionDocumento { get; set; }
        public string? FuenteConciliacion { get; set; }
        public string? DocumentoConciliacion { get; set; }
        public string? FechaComprobanteConciliacion { get; set; }
        public string? ItemConciliacion { get; set; }
        public string? DescripcionDocumentoConciliacion { get; set; }
        public string? UsuarioAprobacion { get; set; }
        public string? Usuario { get; set; }
        public decimal? TasaCambio { get; set; }
        public string? Pppconciliacion { get; set; }
        public string Bu { get; set; } = null!;
        public string ConsultarBu { get; set; } = null!;
        public bool Directa { get; set; }

        public virtual ContPppMetodoPago? IdenMetodoPagoNavigation { get; set; }
        public virtual ICollection<ContPppProgramacionesFactura> ContPppProgramacionesFacturas { get; set; }
        public virtual ICollection<ContPppProgramacionesPago> ContPppProgramacionesPagos { get; set; }
    }
}
