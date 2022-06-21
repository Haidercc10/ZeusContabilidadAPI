using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class TempCausacionMora
    {
        public int Id { get; set; }
        public int SpId { get; set; }
        public int ProcessId { get; set; }
        public decimal? IdenDocumento { get; set; }
        public string? Tipo { get; set; }
        public decimal? IdenCuota { get; set; }
        public string Codicta { get; set; } = null!;
        public string Idcliprv { get; set; } = null!;
        public string Tipofact { get; set; } = null!;
        public string Numefac { get; set; } = null!;
        public string Vencefac { get; set; } = null!;
        public string Refefac { get; set; } = null!;
        public decimal? Sactfac { get; set; }
        public decimal? PorcIvaFact { get; set; }
        public decimal? PorcMora { get; set; }
        public decimal? PorcIvaMora { get; set; }
        public DateTime? FechaUltimaMora { get; set; }
        public decimal Dias { get; set; }
        public int TipoCalcIntMora { get; set; }
        public decimal ValorMora { get; set; }
        public decimal ValorIvaMora { get; set; }
        public decimal ValorMoraNeto { get; set; }
        public decimal ValorIvaMoraNeto { get; set; }
        public bool BtExcluirCxC { get; set; }
        public string? Bu { get; set; }
        public string? IdcliprvAsumeIm { get; set; }
    }
}
