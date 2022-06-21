using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class SriCategorium
    {
        public int? SpId { get; set; }
        public string? Fuente { get; set; }
        public string? Documento { get; set; }
        public string? Categoria { get; set; }
        public string? Tipo { get; set; }
        public string? Concepto { get; set; }
        public int IdenSriCategoria { get; set; }
    }
}
