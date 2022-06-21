using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class SaldoprovI
    {
        public string Anomescta { get; set; } = null!;
        public decimal? Sdancta { get; set; }
        public decimal? Mvdbcta { get; set; }
        public decimal? Mvcrcta { get; set; }
        public decimal? Sdaccta { get; set; }
        public decimal Sdanmcta { get; set; }
        public decimal Mvdbmcta { get; set; }
        public decimal Mvcrmcta { get; set; }
        public decimal Sdacmcta { get; set; }
        public decimal Sdanmon1 { get; set; }
        public decimal Mvdbmon1 { get; set; }
        public decimal Mvcrmon1 { get; set; }
        public decimal Sdacmon1 { get; set; }
        public decimal Sdanmon2 { get; set; }
        public decimal Mvdbmon2 { get; set; }
        public decimal Mvcrmon2 { get; set; }
        public decimal Sdacmon2 { get; set; }
        public int IdenSaldoprovI { get; set; }
    }
}
