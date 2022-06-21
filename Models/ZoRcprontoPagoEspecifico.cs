using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class ZoRcprontoPagoEspecifico
    {
        public int Iden { get; set; }
        public string Tipo { get; set; } = null!;
        public string IdCodigo { get; set; } = null!;
        public int Dias { get; set; }
        public decimal Porcentaje { get; set; }
        public string? Cuenta { get; set; }
    }
}
