using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class Ctasconc
    {
        public string ConcFco { get; set; } = null!;
        public string CodiFco { get; set; } = null!;
        public string DbcrFco { get; set; } = null!;
        public string? BaseFco { get; set; }
        public string FormuFco { get; set; } = null!;
        public string? CondiFco { get; set; }
        public string? DetalleFco { get; set; }
        public int IdenCtasconc { get; set; }
    }
}
