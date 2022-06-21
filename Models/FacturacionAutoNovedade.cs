using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class FacturacionAutoNovedade
    {
        public FacturacionAutoNovedade()
        {
            FacturacionAutoConceptos = new HashSet<FacturacionAutoConcepto>();
        }

        public decimal Iden { get; set; }
        public decimal Consecutivo { get; set; }
        public DateTime Fecha { get; set; }
        public string? Descripcion { get; set; }
        public string Estado { get; set; } = null!;
        public string? Moneda { get; set; }
        public DateTime? FechaTasa { get; set; }
        public decimal TasaCambio { get; set; }
        public string? Usuario { get; set; }
        public bool? ProgramarNovedad { get; set; }
        public string? FechaProgramacionInicial { get; set; }
        public string? FechaProgramacionFinal { get; set; }
        public bool? ControlProgramacion { get; set; }

        public virtual ICollection<FacturacionAutoConcepto> FacturacionAutoConceptos { get; set; }
    }
}
