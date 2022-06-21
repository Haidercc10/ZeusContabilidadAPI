using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class Factcuotum
    {
        public string? FuenteCuo { get; set; }
        public string? DocumCuo { get; set; }
        public int? CuotasCuo { get; set; }
        public string? VctoiniCuo { get; set; }
        public decimal? ValorCuo { get; set; }
        public decimal ValorMonedaCuo { get; set; }
        public int IdenFactcuota { get; set; }
        public byte[] VersionDeLaFila { get; set; } = null!;
        public string? Bu { get; set; }
        public string? CodigoCxC { get; set; }
    }
}
