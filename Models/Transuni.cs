using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class Transuni
    {
        public string Anotra { get; set; } = null!;
        public string Idfuente { get; set; } = null!;
        public string Numdoctra { get; set; } = null!;
        public int Consecutra { get; set; }
        public string Idunidad { get; set; } = null!;
        public decimal Valorutra { get; set; }
        public decimal? Valormoneda { get; set; }
        public int? Consecurev { get; set; }
        public decimal Valormoneda1 { get; set; }
        public decimal Valormoneda2 { get; set; }
        public int IdenTransuni { get; set; }
    }
}
