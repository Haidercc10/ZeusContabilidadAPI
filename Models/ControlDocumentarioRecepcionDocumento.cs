using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class ControlDocumentarioRecepcionDocumento
    {
        public ControlDocumentarioRecepcionDocumento()
        {
            FactdocHeads = new HashSet<FactdocHead>();
        }

        public decimal Consecutivo { get; set; }
        public DateTime Fecha { get; set; }
        public decimal Estado { get; set; }
        public string Usuario { get; set; } = null!;
        public string Proveedor { get; set; } = null!;
        public string NumeroFactura { get; set; } = null!;
        public string? TipoFactura { get; set; }
        public string? Referencia { get; set; }
        public string Serie { get; set; } = null!;
        public string Separador { get; set; } = null!;
        public string NumConsecutivo { get; set; } = null!;

        public virtual ControlDocumentarioEstado EstadoNavigation { get; set; } = null!;
        public virtual ICollection<FactdocHead> FactdocHeads { get; set; }
    }
}
