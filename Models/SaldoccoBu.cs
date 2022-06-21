using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class SaldoccoBu
    {
        public string Bu { get; set; } = null!;
        public string Codicta { get; set; } = null!;
        public string Idcenco { get; set; } = null!;
        public string Idunidad { get; set; } = null!;
        public string Anomescco { get; set; } = null!;
        public decimal Sdancco { get; set; }
        public decimal Mvdbcco { get; set; }
        public decimal Mvcrcco { get; set; }
        public decimal Sdaccco { get; set; }
        public decimal Sdanmcco { get; set; }
        public decimal Mvdbmcco { get; set; }
        public decimal Mvcrmcco { get; set; }
        public decimal Sdacmcco { get; set; }
        public decimal Sdanmon1 { get; set; }
        public decimal Mvdbmon1 { get; set; }
        public decimal Mvcrmon1 { get; set; }
        public decimal Sdacmon1 { get; set; }
        public decimal Sdanmon2 { get; set; }
        public decimal Mvdbmon2 { get; set; }
        public decimal Mvcrmon2 { get; set; }
        public decimal Sdacmon2 { get; set; }
        public decimal SdanccoT { get; set; }
        public decimal SdacccoT { get; set; }
        public decimal SdanmccoT { get; set; }
        public decimal SdacmccoT { get; set; }
        public int IdenSaldoccoBu { get; set; }
        public byte[] VersionDeLaFila { get; set; } = null!;

        public virtual Bu BuNavigation { get; set; } = null!;
        public virtual Maecont CodictaNavigation { get; set; } = null!;
        public virtual Maecco IdcencoNavigation { get; set; } = null!;
    }
}
