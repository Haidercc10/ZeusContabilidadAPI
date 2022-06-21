using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class CategoriaRpt
    {
        public string Codigo { get; set; } = null!;
        public string Nombre { get; set; } = null!;
        public int IdenCategoriarpt { get; set; }
    }
}
