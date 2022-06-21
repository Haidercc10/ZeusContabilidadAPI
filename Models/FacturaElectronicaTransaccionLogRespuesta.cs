using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class FacturaElectronicaTransaccionLogRespuesta
    {
        public decimal Iden { get; set; }
        public decimal FacturaElectronicaTransaccionId { get; set; }
        public string Estado { get; set; } = null!;
        public string Mensaje { get; set; } = null!;
        public DateTime Procesado { get; set; }
        public string? XmlRespuesta { get; set; }

        public virtual FacturaElectronicaTransaccion FacturaElectronicaTransaccion { get; set; } = null!;
    }
}
