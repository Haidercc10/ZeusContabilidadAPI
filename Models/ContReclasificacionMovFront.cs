using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class ContReclasificacionMovFront
    {
        public decimal Id { get; set; }
        public DateTime FechaGrabacion { get; set; }
        public string NodoXml { get; set; } = null!;
        public string Operacion { get; set; } = null!;
    }
}
