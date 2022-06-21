using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class ZeusPararActualizacionSaldo
    {
        public decimal Id { get; set; }
        public DateTime? Fecha { get; set; }
        public string? Proceso { get; set; }
        public string? Usuario { get; set; }
        public short? SpId { get; set; }
        public bool? Estado { get; set; }
    }
}
