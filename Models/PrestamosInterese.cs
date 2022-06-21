using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class PrestamosInterese
    {
        public decimal Id { get; set; }
        public string TipoInteres { get; set; } = null!;
        public string Fecha { get; set; } = null!;
        public string Fuente { get; set; } = null!;
        public string Documento { get; set; } = null!;
        public decimal Interes { get; set; }
        public string Estado { get; set; } = null!;
    }
}
