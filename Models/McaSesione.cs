using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class McaSesione
    {
        public decimal IdSesion { get; set; }
        public DateTime? FechaHoraIngreso { get; set; }
        public string? Usuario { get; set; }
        public string? Maquina { get; set; }
    }
}
