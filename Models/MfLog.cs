using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class MfLog
    {
        public int Id { get; set; }
        public string TipoEstudio { get; set; } = null!;
        public int CodEstudio { get; set; }
        public string Estado { get; set; } = null!;
        public string Usuario { get; set; } = null!;
        public DateTime Fecha { get; set; }
        public string Observaciones { get; set; } = null!;
        public string Operacion { get; set; } = null!;
        public string CodGrupo { get; set; } = null!;
        public string UsuarioAprobacion { get; set; } = null!;
    }
}
