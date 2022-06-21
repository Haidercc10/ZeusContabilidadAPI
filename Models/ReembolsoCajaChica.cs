using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class ReembolsoCajaChica
    {
        public decimal Iden { get; set; }
        public decimal Consecutivo { get; set; }
        public decimal ConsecutivoExterno { get; set; }
        public string FechaCaja { get; set; } = null!;
        public string MetodoDePago { get; set; } = null!;
        public string PersonalAutorizacion { get; set; } = null!;
        public string Detalle { get; set; } = null!;
        public string Usuario { get; set; } = null!;
        public int Estado { get; set; }
    }
}
