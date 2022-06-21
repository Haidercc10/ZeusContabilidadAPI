using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class SaldoPropiedad3
    {
        public string Anomescta { get; set; } = null!;
        public string Bu { get; set; } = null!;
        public string Codicta { get; set; } = null!;
        public string Idunidad { get; set; } = null!;
        public string Propiedad3 { get; set; } = null!;
        public decimal? Sdancta { get; set; }
        public decimal? Mvdbcta { get; set; }
        public decimal? Mvcrcta { get; set; }
        public decimal? Sdaccta { get; set; }
        public decimal? Sdanmcta { get; set; }
        public decimal? Mvdbmcta { get; set; }
        public decimal? Mvcrmcta { get; set; }
        public decimal? Sdacmcta { get; set; }
        public decimal? Sdanmon1 { get; set; }
        public decimal? Mvdbmon1 { get; set; }
        public decimal? Mvcrmon1 { get; set; }
        public decimal? Sdacmon1 { get; set; }
        public decimal? Sdanmon2 { get; set; }
        public decimal? Mvdbmon2 { get; set; }
        public decimal? Mvcrmon2 { get; set; }
        public decimal? Sdacmon2 { get; set; }
        public decimal? SdanctaT { get; set; }
        public decimal? SdacctaT { get; set; }
        public decimal? SdanmctaT { get; set; }
        public decimal? SdacmctaT { get; set; }
        public int IdenSaldopropiedad3 { get; set; }
        public byte[] VersionDeLaFila { get; set; } = null!;

        public virtual Bu BuNavigation { get; set; } = null!;
        public virtual Maecont CodictaNavigation { get; set; } = null!;
        public virtual Propiedad3 Propiedad3Navigation { get; set; } = null!;
    }
}
