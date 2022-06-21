using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class ControlCambioEnObjeto
    {
        public int Id { get; set; }
        public DateTime Fc { get; set; }
        public DateTime? Fm { get; set; }
        public int IdenControlcambioenobjetos { get; set; }
    }
}
