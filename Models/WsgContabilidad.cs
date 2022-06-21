using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class WsgContabilidad
    {
        public int Id { get; set; }
        public int Accion { get; set; }
        public string? XmlValue { get; set; }
        public DateTime? FechaGrabacion { get; set; }
    }
}
