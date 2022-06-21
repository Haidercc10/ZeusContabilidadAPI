using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class SaldoauxI
    {
        public string Anoaux { get; set; } = null!;
        public decimal? Sdanaux { get; set; }
        public decimal? Mvdbaux { get; set; }
        public decimal? Mvcraux { get; set; }
        public decimal? Sdacaux { get; set; }
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
        public int IdenSaldoauxI { get; set; }
    }
}
