using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class MfEscVehiculo
    {
        public int IdVehiculo { get; set; }
        public int IdescPadre { get; set; }
        public string Marca { get; set; } = null!;
        public string Modelo { get; set; } = null!;
        public string Placa { get; set; } = null!;
        public string Nmotor { get; set; } = null!;
        public string Reservadominio { get; set; } = null!;

        public virtual MfEscTablapadre IdescPadreNavigation { get; set; } = null!;
    }
}
