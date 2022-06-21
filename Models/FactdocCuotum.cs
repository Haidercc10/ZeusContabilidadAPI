using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class FactdocCuotum
    {
        public decimal Iden { get; set; }
        public string FuenteCuo { get; set; } = null!;
        public string DocumentoCuo { get; set; } = null!;
        public int? CuotasCuo { get; set; }
        public string? VctoiniCuo { get; set; }
        public decimal? ValorCuo { get; set; }
        public string FuenteExportCuo { get; set; } = null!;
        public string DocumentoExportCuo { get; set; } = null!;
        public decimal? IdenRelacionado { get; set; }
        public decimal ValorMonedaCuo { get; set; }
        public byte[] VersionDeLaFila { get; set; } = null!;
        public string? Bu { get; set; }
        public string? CodigoCxC { get; set; }

        public virtual Fuente FuenteCuoNavigation { get; set; } = null!;
    }
}
