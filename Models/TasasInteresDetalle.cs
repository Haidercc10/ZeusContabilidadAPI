using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class TasasInteresDetalle
    {
        public decimal IdenTasasInteres { get; set; }
        public double Tasa { get; set; }
        public string Fecha { get; set; } = null!;
        public string FechaFinal { get; set; } = null!;
        public int IdenTasasinteresDetalle { get; set; }

        public virtual TasasIntere IdenTasasInteresNavigation { get; set; } = null!;
    }
}
