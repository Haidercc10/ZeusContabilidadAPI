using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class SaldoAuxBuLibroPrincipal
    {
        public string Bu { get; set; } = null!;
        public string Codicta { get; set; } = null!;
        public string Idunidad { get; set; } = null!;
        public string Anoaux { get; set; } = null!;
        public string Auxiaux { get; set; } = null!;
        public decimal Sdanaux { get; set; }
        public decimal Mvdbaux { get; set; }
        public decimal Mvcraux { get; set; }
        public decimal Sdacaux { get; set; }
        public decimal Sdanmaux { get; set; }
        public decimal Mvdbmaux { get; set; }
        public decimal Mvcrmaux { get; set; }
        public decimal Sdacmaux { get; set; }
    }
}
