using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class EscenariosTributarioIcatCiudad
    {
        public decimal Iden { get; set; }
        public decimal EscenariosTributarioIcatIden { get; set; }
        public decimal EscenariosCiudadIden { get; set; }
        public DateTime FechaEfectiva { get; set; }
        public decimal Porcentaje { get; set; }

        public virtual EscenariosCiudad EscenariosCiudadIdenNavigation { get; set; } = null!;
        public virtual EscenariosTributarioIcat EscenariosTributarioIcatIdenNavigation { get; set; } = null!;
    }
}
