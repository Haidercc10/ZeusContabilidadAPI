using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class DefinicionDeDocumento
    {
        public int Id { get; set; }
        public string CodigoDocumento { get; set; } = null!;
        public string Nombre { get; set; } = null!;
        public int? ManejaAprobacion { get; set; }
    }
}
