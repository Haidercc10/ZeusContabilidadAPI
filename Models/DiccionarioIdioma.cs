using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class DiccionarioIdioma
    {
        public int Id { get; set; }
        public string Modulo { get; set; } = null!;
        public string Frase { get; set; } = null!;
        public string? Ingles { get; set; }
        public string? Frances { get; set; }
        public string? Aleman { get; set; }
        public string? Italiano { get; set; }
        public string? Portugues { get; set; }
        public string? Forma { get; set; }
    }
}
