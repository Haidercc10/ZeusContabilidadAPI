using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class Pago3rosLibroPrincipal
    {
        public string Codicta { get; set; } = null!;
        public string Idtercero { get; set; } = null!;
        public string Anomes { get; set; } = null!;
        public decimal? Sdancta { get; set; }
        public decimal? Mvdb { get; set; }
        public decimal? Mvcr { get; set; }
        public decimal? Sdaccta { get; set; }
        public decimal? Sdanmcta { get; set; }
        public decimal? Mvdbmcta { get; set; }
        public decimal? Mvcrmcta { get; set; }
        public decimal? Sdacmcta { get; set; }
    }
}
