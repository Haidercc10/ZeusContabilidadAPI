using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class ClientesCuentasPorMonedum
    {
        public decimal Iden { get; set; }
        public string Idcliente { get; set; } = null!;
        public string? Idmoneda { get; set; }
        public string? Codicta { get; set; }
        public string? Codictaremision { get; set; }
        public decimal CupoCredito { get; set; }
    }
}
