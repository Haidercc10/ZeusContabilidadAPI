using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class TempCausacionMoraDetalle
    {
        public int Id { get; set; }
        public int IdenRelacionado { get; set; }
        public int SpId { get; set; }
        public int ProcessId { get; set; }
        public string Codicta { get; set; } = null!;
        public string Idcliprv { get; set; } = null!;
        public string Tipofact { get; set; } = null!;
        public string Numefac { get; set; } = null!;
        public string Vencefac { get; set; } = null!;
        public string Refefac { get; set; } = null!;
        public decimal? Santfac { get; set; }
        public decimal? PorcIvaFact { get; set; }
        public decimal ValorPago { get; set; }
        public DateTime FechaPago { get; set; }
        public decimal? PorcMora { get; set; }
        public decimal? PorcIvaMora { get; set; }
        public DateTime? FechaUltimaMora { get; set; }
        public decimal Dias { get; set; }
        public int TipoCalcIntMora { get; set; }
        public decimal ValorMora { get; set; }
        public decimal ValorIvaMora { get; set; }
        public string? Fuente { get; set; }
        public string? Documento { get; set; }
        public string? Bu { get; set; }
        public string? IdcliprvAsumeIm { get; set; }
    }
}
