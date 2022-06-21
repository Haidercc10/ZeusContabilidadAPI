using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class ReciboPagoTemp
    {
        public ReciboPagoTemp()
        {
            ReciboPagoTempGrids = new HashSet<ReciboPagoTempGrid>();
        }

        public decimal Iden { get; set; }
        public int TipoRecibo { get; set; }
        public string Fecha { get; set; } = null!;
        public string Cliente { get; set; } = null!;
        public decimal TasaCambio { get; set; }
        public string CtaContrapartida { get; set; } = null!;
        public string Fuente { get; set; } = null!;
        public string Documento { get; set; } = null!;
        public string Observacion { get; set; } = null!;
        public decimal ValorApagar { get; set; }
        public string Usuario { get; set; } = null!;
        public DateTime FechaCreacion { get; set; }

        public virtual ICollection<ReciboPagoTempGrid> ReciboPagoTempGrids { get; set; }
    }
}
