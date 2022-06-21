using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class FactConcValorPeriodo
    {
        public int Iden { get; set; }
        public string? Concepto { get; set; }
        public string? Idcliente { get; set; }
        public decimal? Anno { get; set; }
        public string? Mes { get; set; }
        public decimal? Valor { get; set; }
        public string? Bu { get; set; }
    }
}
