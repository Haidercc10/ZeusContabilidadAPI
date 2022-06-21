using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class TransacProcesado
    {
        public decimal Iden { get; set; }
        public decimal Consecutra { get; set; }
        public DateTime? FechaGrabacion { get; set; }
        public string? Auxiliar { get; set; }
    }
}
