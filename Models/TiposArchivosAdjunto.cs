using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class TiposArchivosAdjunto
    {
        public decimal Iden { get; set; }
        public string Tipo { get; set; } = null!;
        public string Descripcion { get; set; } = null!;
        public bool EnviarFacturaE { get; set; }
    }
}
