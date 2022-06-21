using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class ContSistemasAperturaLibroSaldoClieBu
    {
        public decimal Iden { get; set; }
        public decimal IdenPreparacion { get; set; }
        public string Bu { get; set; } = null!;
        public string Cuenta { get; set; } = null!;
        public string Cliente { get; set; } = null!;
        public decimal SaldoActual { get; set; }
        public decimal SaldoActualMoneda { get; set; }
        public decimal SaldoActualUnidad1 { get; set; }
        public decimal SaldoActualUnidad2 { get; set; }
        public decimal SaldoActualUnidad3 { get; set; }
        public decimal SaldoActualNuevo { get; set; }
        public decimal SaldoActualMonedaNuevo { get; set; }
        public decimal SaldoActualUnidad1Nuevo { get; set; }
        public decimal SaldoActualUnidad2Nuevo { get; set; }
        public decimal SaldoActualUnidad3Nuevo { get; set; }
    }
}
