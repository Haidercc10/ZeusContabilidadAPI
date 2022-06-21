using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class FormaPagoAge
    {
        public int IdFormaPago { get; set; }
        public string Fuente { get; set; } = null!;
        public string Documento { get; set; } = null!;
        public string Cuenta { get; set; } = null!;
        public string Cliente { get; set; } = null!;
        public string TipoFac { get; set; } = null!;
        public string Numefac { get; set; } = null!;
        public string Vencefac { get; set; } = null!;
        public string Refefac { get; set; } = null!;
        public string FormaPago { get; set; } = null!;
        public string Bu { get; set; } = null!;
    }
}
