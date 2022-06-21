using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class EsquemaDocumento
    {
        public decimal Iden { get; set; }
        public string Fuente { get; set; } = null!;
        public string Documento { get; set; } = null!;
        public bool Aplicado { get; set; }
        public decimal Intentos { get; set; }
        public string Error { get; set; } = null!;
        public string Usuario { get; set; } = null!;
    }
}
