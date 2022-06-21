using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class ContDatosSincronizacion
    {
        public decimal Id { get; set; }
        public string? TextSql { get; set; }
        public string? IdUsuarioCont { get; set; }
        public DateTime? FechaRegistro { get; set; }
        public string? IndSincronizacion { get; set; }
    }
}
