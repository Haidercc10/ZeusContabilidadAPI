using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class ZeusMqRecibido
    {
        public decimal Iden { get; set; }
        public Guid? IdUnico { get; set; }
        public string? Mensaje { get; set; }
        public DateTime? Fecha { get; set; }
    }
}
