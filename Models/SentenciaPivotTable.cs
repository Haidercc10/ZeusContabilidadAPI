using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class SentenciaPivotTable
    {
        public decimal Id { get; set; }
        public string Sentencia { get; set; } = null!;
    }
}
