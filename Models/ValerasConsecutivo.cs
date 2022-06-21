using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class ValerasConsecutivo
    {
        public decimal Id { get; set; }
        public string Nombre { get; set; } = null!;
        public decimal Consecutivo { get; set; }
        public int IdenValerasConsecutivos { get; set; }
    }
}
