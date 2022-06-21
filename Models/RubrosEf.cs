using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class RubrosEf
    {
        public decimal IdenCatalogo { get; set; }
        public string Libro { get; set; } = null!;
        public string Codigo { get; set; } = null!;
        public string Descripcion { get; set; } = null!;
        public int IdenRubrosef { get; set; }
    }
}
