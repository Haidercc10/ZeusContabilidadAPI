using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class ScProgramacionFacturaTemp
    {
        public int SpId { get; set; }
        public string AnoMes { get; set; } = null!;
        public string Cuenta { get; set; } = null!;
        public string Cliente { get; set; } = null!;
        public string TipoFact { get; set; } = null!;
        public string NumeFact { get; set; } = null!;
        public string VenceFact { get; set; } = null!;
        public string RefeFact { get; set; } = null!;
        public string Bu { get; set; } = null!;
        public decimal TotalMora { get; set; }
        public decimal TotalIvaMora { get; set; }
        public int IdenScProgramacionfacturatemp { get; set; }
    }
}
