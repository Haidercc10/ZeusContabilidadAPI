using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class Pago3rosI
    {
        public string Anomes { get; set; } = null!;
        public decimal? Mvdb { get; set; }
        public decimal? Mvcr { get; set; }
        public decimal Sdancta { get; set; }
        public decimal Sdaccta { get; set; }
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
        public int IdenPago3rosI { get; set; }
    }
}
