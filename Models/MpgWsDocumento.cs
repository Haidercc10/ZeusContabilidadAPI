using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class MpgWsDocumento
    {
        public decimal Iden { get; set; }
        public decimal IdenMpgNomina { get; set; }
        public decimal IdenRelacionado { get; set; }
        public string Xmlvalue { get; set; } = null!;
        public string FechaProceso { get; set; } = null!;
        public decimal IdenMpgDocumento { get; set; }
        public decimal? IdenProgramacion { get; set; }
        public string Respuesta { get; set; } = null!;
    }
}
