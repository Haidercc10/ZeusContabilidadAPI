using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class ImpresoraFiscalParametro
    {
        public decimal Iden { get; set; }
        public string Codigo { get; set; } = null!;
        public string Nombre { get; set; } = null!;
        public string Valor { get; set; } = null!;
        public int Orden { get; set; }
    }
}
