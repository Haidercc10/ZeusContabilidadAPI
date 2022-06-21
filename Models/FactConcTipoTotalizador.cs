using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class FactConcTipoTotalizador
    {
        public string Codigo { get; set; } = null!;
        public string Descripcion { get; set; } = null!;
        public int Orden { get; set; }
        public int IdenFactconctipototalizador { get; set; }
    }
}
