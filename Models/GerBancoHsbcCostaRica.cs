using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class GerBancoHsbcCostaRica
    {
        public string Cuenta { get; set; } = null!;
        public string? Nivelautorizacion { get; set; }
        public int? Tpago { get; set; }
        public string? Fdebito { get; set; }
        public string? Prioridad { get; set; }
        public string? Moneda { get; set; }
        public int IdenGerbancohsbccostarica { get; set; }
    }
}
