using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class ZwsLog
    {
        public decimal Iden { get; set; }
        public string? Valor { get; set; }
        public string? Tipo { get; set; }
        public DateTime? Fecha { get; set; }
    }
}
