using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class EscenariosImpuestosPaisMoneda
    {
        public decimal Iden { get; set; }
        public decimal EscenariosImpuestosPaisIden { get; set; }
        public string IdMoneda { get; set; } = null!;
        public int Redondeo { get; set; }

        public virtual EscenariosImpuestosPai EscenariosImpuestosPaisIdenNavigation { get; set; } = null!;
    }
}
