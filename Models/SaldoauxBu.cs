using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class SaldoauxBu
    {
        public string Bu { get; set; } = null!;
        public string Codicta { get; set; } = null!;
        public string Auxiaux { get; set; } = null!;
        public string Idunidad { get; set; } = null!;
        public string Anoaux { get; set; } = null!;
        public decimal Sdanaux { get; set; }
        public decimal Mvdbaux { get; set; }
        public decimal Mvcraux { get; set; }
        public decimal Sdacaux { get; set; }
        public decimal Sdanmaux { get; set; }
        public decimal Mvdbmaux { get; set; }
        public decimal Mvcrmaux { get; set; }
        public decimal Sdacmaux { get; set; }
        public decimal Sdanmon1 { get; set; }
        public decimal Mvdbmon1 { get; set; }
        public decimal Mvcrmon1 { get; set; }
        public decimal Sdacmon1 { get; set; }
        public decimal Sdanmon2 { get; set; }
        public decimal Mvdbmon2 { get; set; }
        public decimal Mvcrmon2 { get; set; }
        public decimal Sdacmon2 { get; set; }
        public decimal SdanauxT { get; set; }
        public decimal SdacauxT { get; set; }
        public decimal SdanmauxT { get; set; }
        public decimal SdacmauxT { get; set; }
        public int IdenSaldoauxBu { get; set; }
        public byte[] VersionDeLaFila { get; set; } = null!;

        public virtual Auxiliar Auxiliar { get; set; } = null!;
        public virtual Bu BuNavigation { get; set; } = null!;
        public virtual Maecont CodictaNavigation { get; set; } = null!;
    }
}
