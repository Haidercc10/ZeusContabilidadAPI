using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class InterfazPeticione
    {
        public decimal Iden { get; set; }
        public Guid TransaccionId { get; set; }
        public DateTime FechaHoraGrabacion { get; set; }
        public decimal InterfazIden { get; set; }
        public string? PeticionXml { get; set; }
        public string? Estado { get; set; }
        public string? UltimoMensaje { get; set; }
        public int? Intentos { get; set; }
        public DateTime? FechaHoraProcesado { get; set; }
    }
}
