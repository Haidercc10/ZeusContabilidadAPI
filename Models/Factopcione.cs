using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class Factopcione
    {
        public string Nombre { get; set; } = null!;
        public string Descripcion { get; set; } = null!;
        public string? DescripcionLarga { get; set; }
        public string Presentacion { get; set; } = null!;
        public string? Execsql { get; set; }
        public string ValorDefault { get; set; } = null!;
        public int? Orden { get; set; }
        public string? Aplicacion { get; set; }
        public int IdenFactopciones { get; set; }
    }
}
