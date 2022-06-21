using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class UsuariosLibro
    {
        public string? Usuario { get; set; }
        public decimal? IdenLibro { get; set; }
        public int IdenUsuariosLibros { get; set; }
    }
}
