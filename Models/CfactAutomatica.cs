using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class CfactAutomatica
    {
        public decimal Iden { get; set; }
        public string Fecha { get; set; } = null!;
        public string CtaCobrar { get; set; } = null!;
        public string Fuente { get; set; } = null!;
        public string Moneda { get; set; } = null!;
        public decimal TasaCambio { get; set; }
        public decimal? RegistroNovedad { get; set; }
        public string DocumentoI { get; set; } = null!;
        public string DocumentoF { get; set; } = null!;
        public string? Ciclos { get; set; }
        public string Usuario { get; set; } = null!;
        public string Bu { get; set; } = null!;
        public int Dias { get; set; }
        public decimal Cantidad { get; set; }
        public decimal Valor { get; set; }
        public int Revertido { get; set; }
    }
}
