using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class ValerasFpfactura
    {
        public int IdValerasFp { get; set; }
        public string Fuente { get; set; } = null!;
        public string Documento { get; set; } = null!;
        public string Vale { get; set; } = null!;
        public decimal ConsecutivoVale { get; set; }
        public decimal Valor { get; set; }
        public string Estado { get; set; } = null!;
    }
}
