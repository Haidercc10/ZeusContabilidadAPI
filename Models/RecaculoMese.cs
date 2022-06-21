using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class RecaculoMese
    {
        public string AnoMes { get; set; } = null!;
        public DateTime? TiempoI { get; set; }
        public DateTime? TiempoF { get; set; }
        public int? Segundo { get; set; }
        public int IdenRecaculomeses { get; set; }
    }
}
