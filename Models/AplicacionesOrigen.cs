using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class AplicacionesOrigen
    {
        public int Id { get; set; }
        public string NombreMostrar { get; set; } = null!;
        public string Servidor { get; set; } = null!;
        public string Base { get; set; } = null!;
        public string Usuario { get; set; } = null!;
        public string Clave { get; set; } = null!;
        public int IdAplicacionesZeus { get; set; }
        public int Estado { get; set; }
    }
}
