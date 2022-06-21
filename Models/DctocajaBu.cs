using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class DctocajaBu
    {
        public string Bu { get; set; } = null!;
        public string Codicta { get; set; } = null!;
        public string Idunidad { get; set; } = null!;
        public string Anomescj { get; set; } = null!;
        public string Idmoneda { get; set; } = null!;
        public string Ndctcja { get; set; } = null!;
        public string Fechcja { get; set; } = null!;
        public string Idbanco { get; set; } = null!;
        public string? Idplaza { get; set; }
        public decimal Santcja { get; set; }
        public decimal Mvdbcja { get; set; }
        public decimal Mvcrcja { get; set; }
        public decimal Sactcja { get; set; }
        public decimal Sanmcja { get; set; }
        public decimal Mvdbmcja { get; set; }
        public decimal Mvcrmcja { get; set; }
        public decimal Sacmcja { get; set; }
        public DateTime? Feumcja { get; set; }
        public string? Nitcja { get; set; }
        public decimal? Ivainformado { get; set; }
        public string? Fechconsg { get; set; }
        public string? Fnteconsg { get; set; }
        public string? Doctconsg { get; set; }
        public string? FuenteRc { get; set; }
        public string? DocumentoRc { get; set; }
        public string? Referencia { get; set; }
        public decimal? Basecomision { get; set; }
        public decimal Sdanmon1 { get; set; }
        public decimal Mvdbmon1 { get; set; }
        public decimal Mvcrmon1 { get; set; }
        public decimal Sdacmon1 { get; set; }
        public decimal Sdanmon2 { get; set; }
        public decimal Mvdbmon2 { get; set; }
        public decimal Mvcrmon2 { get; set; }
        public decimal Sdacmon2 { get; set; }
        public int IdenDctocajaBu { get; set; }
        public byte[] VersionDeLaFila { get; set; } = null!;

        public virtual Bu BuNavigation { get; set; } = null!;
        public virtual Maecont CodictaNavigation { get; set; } = null!;
    }
}
