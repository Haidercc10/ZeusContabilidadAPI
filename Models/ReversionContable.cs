using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class ReversionContable
    {
        public int IdRev { get; set; }
        public string Fuente { get; set; } = null!;
        public string Documento { get; set; } = null!;
        public string FuenteRevertido { get; set; } = null!;
        public string DocumentoRevertido { get; set; } = null!;
        public string FuenteNuevo { get; set; } = null!;
        public string DocumentoNuevo { get; set; } = null!;
    }
}
