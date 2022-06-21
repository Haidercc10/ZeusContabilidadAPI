using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class Saldorefe
    {
        public string Bu { get; set; } = null!;
        public string Codicta { get; set; } = null!;
        public string Idtercero { get; set; } = null!;
        public string Idrefe { get; set; } = null!;
        public string Anomes { get; set; } = null!;
        public decimal Sdanrefe { get; set; }
        public decimal Mvdbrefe { get; set; }
        public decimal Mvcrrefe { get; set; }
        public decimal Sdacrefe { get; set; }
        public decimal Sdanmrefe { get; set; }
        public decimal Mvdbmrefe { get; set; }
        public decimal Mvcrmrefe { get; set; }
        public decimal Sdacmrefe { get; set; }
        public decimal Sdanmon1 { get; set; }
        public decimal Mvdbmon1 { get; set; }
        public decimal Mvcrmon1 { get; set; }
        public decimal Sdacmon1 { get; set; }
        public decimal Sdanmon2 { get; set; }
        public decimal Mvdbmon2 { get; set; }
        public decimal Mvcrmon2 { get; set; }
        public decimal Sdacmon2 { get; set; }
        public decimal SdanrefeT { get; set; }
        public decimal SdacrefeT { get; set; }
        public decimal SdanmrefeT { get; set; }
        public decimal SdacmrefeT { get; set; }
        public int IdenSaldoRefeBu { get; set; }
    }
}
