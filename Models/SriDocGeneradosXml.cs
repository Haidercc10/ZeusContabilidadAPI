using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class SriDocGeneradosXml
    {
        public decimal Iden { get; set; }
        public string Fuente { get; set; } = null!;
        public string Documento { get; set; } = null!;
        public string CodigoControl { get; set; } = null!;
        public decimal IdenXmlRecibido { get; set; }
    }
}
