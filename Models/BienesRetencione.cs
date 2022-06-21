using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class BienesRetencione
    {
        public decimal Iden { get; set; }
        public decimal IdenBienes { get; set; }
        public decimal MontoMinimo { get; set; }
        public decimal MontoMaximo { get; set; }
        public decimal VrFijo { get; set; }
        public decimal SobreExcedente { get; set; }
        public decimal Aplicar { get; set; }
    }
}
