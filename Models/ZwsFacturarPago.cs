using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class ZwsFacturarPago
    {
        public int Iden { get; set; }
        public int SpId { get; set; }
        public int IdenHead { get; set; }
        public string Moneda { get; set; } = null!;
        public string Numero { get; set; } = null!;
        public string Vencimiento { get; set; } = null!;
        public string Referencia { get; set; } = null!;
        public string Banco { get; set; } = null!;
        public string Plaza { get; set; } = null!;
        public decimal Valor { get; set; }
        public decimal IvaInformado { get; set; }
    }
}
