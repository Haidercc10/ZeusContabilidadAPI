using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class EscenariosRetencionesMoneda
    {
        public decimal Iden { get; set; }
        public decimal EscenariosRetencionesIden { get; set; }
        public string IdMoneda { get; set; } = null!;
        public int Redondeo { get; set; }

        public virtual EscenariosRetencione EscenariosRetencionesIdenNavigation { get; set; } = null!;
    }
}
