using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class GerCitiBankPaisesMoneda
    {
        public string NombrePais { get; set; } = null!;
        public string CodigoPais { get; set; } = null!;
        public string CodigoMoneda { get; set; } = null!;
        public string NombreMoneda { get; set; } = null!;
        public int IdenGercitibankPaisesmonedas { get; set; }
    }
}
