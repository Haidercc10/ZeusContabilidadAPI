using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class ValesLog
    {
        public decimal IdValesLog { get; set; }
        public decimal IdVale { get; set; }
        public decimal Vale { get; set; }
        public string EstadoOriginal { get; set; } = null!;
        public string EstadoActual { get; set; } = null!;
        public string Descripcion { get; set; } = null!;
        public string Observaciones { get; set; } = null!;
        public string ObservacionesAdicionales { get; set; } = null!;
        public string FuenteCausacion { get; set; } = null!;
        public string DocumentoCausacion { get; set; } = null!;
        public string FechaCausacion { get; set; } = null!;
        public string Usuario { get; set; } = null!;
        public DateTime FechaGrabacion { get; set; }
        public string FuenteConciliacion { get; set; } = null!;
        public string DocumentoConciliacion { get; set; } = null!;
        public string FechaConciliacion { get; set; } = null!;
        public string Vencimiento { get; set; } = null!;

        public virtual Vale IdValeNavigation { get; set; } = null!;
    }
}
