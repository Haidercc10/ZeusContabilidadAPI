using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class ClientesAsobancarium
    {
        public string? Cliente { get; set; }
        public string Valor { get; set; } = null!;
        public int Spid { get; set; }
        public int IdenClientesasobancaria { get; set; }
    }
}
