using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class ContSistemasAperturaLibroSaldoFacturasBu
    {
        public decimal Iden { get; set; }
        public decimal IdenPreparacion { get; set; }
        public string Bu { get; set; } = null!;
        public string Cuenta { get; set; } = null!;
        public string IdCliPrv { get; set; } = null!;
        public string TipoFac { get; set; } = null!;
        public string NumeFac { get; set; } = null!;
        public string VencFac { get; set; } = null!;
        public string RefeFac { get; set; } = null!;
        public string? IdZona { get; set; }
        public string? IdVende { get; set; }
        public string? FechaFac { get; set; }
        public string? Serie { get; set; }
        public string? Autorizacion { get; set; }
        public string? FechaCaducidad { get; set; }
        public string? FechaRadicado { get; set; }
        public string? VenceRadicado { get; set; }
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
