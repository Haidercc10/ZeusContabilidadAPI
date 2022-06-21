using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class TasaDeCambioPorMonedum
    {
        public long Iden { get; set; }
        public string IdMonedaOrigen { get; set; } = null!;
        public string IdMonedaDestino { get; set; } = null!;
        public string FechaInicial { get; set; } = null!;
        public string FechaFinal { get; set; } = null!;
        public double Tasa { get; set; }
        public double Tasa1 { get; set; }
        public double Tasa2 { get; set; }
    }
}
