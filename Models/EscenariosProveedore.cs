using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class EscenariosProveedore
    {
        public decimal Iden { get; set; }
        public string Codigo { get; set; } = null!;
        public decimal? EscenariosCiudadIden { get; set; }

        public virtual EscenariosCiudad? EscenariosCiudadIdenNavigation { get; set; }
    }
}
