using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class ContPppPersonalAutorizacion
    {
        public string Personal { get; set; } = null!;
        public bool Monto { get; set; }
        public decimal MontoValor { get; set; }
        public int TipoAutorizacion { get; set; }
        public int IdenContPppPersonalautorizacion { get; set; }
    }
}
