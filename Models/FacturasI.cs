using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class FacturasI
    {
        public string Anomesfac { get; set; } = null!;
        public decimal? Santfac { get; set; }
        public decimal? Sactfac { get; set; }
        public decimal? Santmfac { get; set; }
        public decimal? Sactmfac { get; set; }
        public decimal Mvdbfac { get; set; }
        public decimal Mvcrfac { get; set; }
        public decimal Mvdbmfac { get; set; }
        public decimal Mvcrmfac { get; set; }
        public decimal Sdanmon1 { get; set; }
        public decimal Mvdbmon1 { get; set; }
        public decimal Mvcrmon1 { get; set; }
        public decimal Sdacmon1 { get; set; }
        public decimal Sdanmon2 { get; set; }
        public decimal Mvdbmon2 { get; set; }
        public decimal Mvcrmon2 { get; set; }
        public decimal Sdacmon2 { get; set; }
        public int IdenFacturasI { get; set; }
    }
}
