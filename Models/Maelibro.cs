using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class Maelibro
    {
        public decimal IdenLibro { get; set; }
        public string Codigo { get; set; } = null!;
        public string Descripcion { get; set; } = null!;
        public string Prefijo { get; set; } = null!;
        public bool Eslibrodeusuario { get; set; }
        public bool Eslibroprincipal { get; set; }
        public bool Deshabilitado { get; set; }
        public string Idmoneda { get; set; } = null!;
        public bool Eslibroniif { get; set; }
        public string? ColorFondoPantalla { get; set; }
        public int? IdColorFondoPantalla { get; set; }
        public bool AplicaAjuste { get; set; }
        public byte[] VersionDeLaFila { get; set; } = null!;
    }
}
