using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class ZeusHotFix
    {
        public decimal Iden { get; set; }
        public string? Ticket { get; set; }
        public string? Descripcion { get; set; }
        public string? Fecha { get; set; }
        public DateTime? FechaAplicacion { get; set; }
    }
}
