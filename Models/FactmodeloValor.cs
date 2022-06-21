using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class FactmodeloValor
    {
        public decimal Iden { get; set; }
        public string Idcliente { get; set; } = null!;
        public string IdDocumento { get; set; } = null!;
        public string IdModelo { get; set; } = null!;
        public string Concepto { get; set; } = null!;
        public decimal Cantidad { get; set; }
        public decimal Valor { get; set; }
        public bool Activo { get; set; }
    }
}
