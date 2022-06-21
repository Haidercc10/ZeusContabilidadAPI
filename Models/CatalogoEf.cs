using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class CatalogoEf
    {
        public decimal Iden { get; set; }
        public string Pais { get; set; } = null!;
        public string Codigo { get; set; } = null!;
        public string Descripcion { get; set; } = null!;
        public bool Deshabilitado { get; set; }
    }
}
