using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class MfGrupo
    {
        public int IdGrupo { get; set; }
        public string Codgrupo { get; set; } = null!;
        public string Nombre { get; set; } = null!;
        public string Estado { get; set; } = null!;
        public string Prestamo { get; set; } = null!;
        public string FechaCreacion { get; set; } = null!;
        public int Simulacion { get; set; }
    }
}
