using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class FacturaElectronicaTransaccion
    {
        public FacturaElectronicaTransaccion()
        {
            FacturaElectronicaTransaccionLogRespuesta = new HashSet<FacturaElectronicaTransaccionLogRespuesta>();
        }

        public decimal Iden { get; set; }
        public string Categoria { get; set; } = null!;
        public string Operacion { get; set; } = null!;
        public string? Llave1 { get; set; }
        public string? Llave2 { get; set; }
        public string? Llave3 { get; set; }
        public string? Llave4 { get; set; }
        public Guid TransaccionGuid { get; set; }
        public string? PeticionXml { get; set; }
        public string? Estado { get; set; }
        public string? UltimoMensaje { get; set; }
        public DateTime? Procesado { get; set; }
        public int? IdFacture { get; set; }
        public string? MensajeNumeroCd { get; set; }
        public string? MensajeRespuestaDs { get; set; }
        public string? MensajeContenidoTecnicoDs { get; set; }
        public string? MensajeDocumentoId { get; set; }
        public string? MensajeFactureTipoCd { get; set; }
        public string? MensajeVisorPublicoUrl { get; set; }
        public string? MensajeErrorInd { get; set; }
        public DateTime? Fecha { get; set; }
        public DateTime? FechaHoraGrabacion { get; set; }
        public int? Intentos { get; set; }
        public string? XmlRespuesta { get; set; }
        public string? Modulo { get; set; }
        public string? ParametrosAdiconles { get; set; }

        public virtual ICollection<FacturaElectronicaTransaccionLogRespuesta> FacturaElectronicaTransaccionLogRespuesta { get; set; }
    }
}
