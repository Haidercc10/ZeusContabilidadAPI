using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class Factpago
    {
        public decimal Iden { get; set; }
        public string FuentePag { get; set; } = null!;
        public string DocumentoPag { get; set; } = null!;
        public string? MonedaPag { get; set; }
        public decimal ValorPag { get; set; }
        public decimal ValormonedaPag { get; set; }
        public string? DocumentoconPag { get; set; }
        public string? BancoPag { get; set; }
        public string? PlazaPag { get; set; }
        public string? AutorizacionPag { get; set; }
        public string? ReferenciaPag { get; set; }
        public string? FechaPag { get; set; }
        public DateTime Fechagrabacion { get; set; }
        public decimal IvainformadoPag { get; set; }
    }
}
