using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class ContPppDetalleTercero
    {
        public decimal Iden { get; set; }
        public decimal CodigoPpp { get; set; }
        public decimal IdenConcepto { get; set; }
        public string Tipo { get; set; } = null!;
        public string Tercero { get; set; } = null!;
        public string Matricula { get; set; } = null!;
        public decimal Valor { get; set; }
    }
}
