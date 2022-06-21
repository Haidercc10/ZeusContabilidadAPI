using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class SistemasFiltro
    {
        public long Iden { get; set; }
        public decimal? IdUsuario { get; set; }
        public DateTime? FechaGrabacion { get; set; }
        public decimal? IdenSesion { get; set; }
    }
}
