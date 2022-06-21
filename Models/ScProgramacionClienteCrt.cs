using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class ScProgramacionClienteCrt
    {
        public decimal IdenProgramacion { get; set; }
        public decimal IdenCliente { get; set; }
        public decimal IdenCriterio { get; set; }
        public string Cliente { get; set; } = null!;
        public int Valor { get; set; }
        public string Observacion { get; set; } = null!;
        public DateTime? Fecha { get; set; }
        public decimal? ValorNumerico { get; set; }
        public DateTime? FechaCriterio { get; set; }
        public int IdenScProgramacionclientecrt { get; set; }

        public virtual ScProgramacionCliente IdenClienteNavigation { get; set; } = null!;
        public virtual ScCriteriosDeCobro IdenCriterioNavigation { get; set; } = null!;
    }
}
