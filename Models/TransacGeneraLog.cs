using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class TransacGeneraLog
    {
        public decimal Consecutra { get; set; }
        public string Error { get; set; } = null!;
        public decimal VecesReportado { get; set; }
        public int IdenTransacGeneraLog { get; set; }
    }
}
