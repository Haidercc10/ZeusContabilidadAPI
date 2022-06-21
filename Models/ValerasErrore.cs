using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class ValerasErrore
    {
        public decimal Numero { get; set; }
        public string Modulo { get; set; } = null!;
        public string Descripcion { get; set; } = null!;
        public int IdenValerasErrores { get; set; }
    }
}
