using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class ReciboPagoTempGrid
    {
        public decimal Iden { get; set; }
        public decimal IdenRecibo { get; set; }
        public int TipoGrid { get; set; }
        public string Cuenta { get; set; } = null!;
        public string ClienteFact { get; set; } = null!;
        public string TipoFact { get; set; } = null!;
        public string NumeFact { get; set; } = null!;
        public string Vencimiento { get; set; } = null!;
        public string Ref { get; set; } = null!;
        public string TextoFila { get; set; } = null!;
        public DateTime FechaCreacion { get; set; }
        public string Bu { get; set; } = null!;

        public virtual ReciboPagoTemp IdenReciboNavigation { get; set; } = null!;
    }
}
