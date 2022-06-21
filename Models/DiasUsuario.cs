using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class DiasUsuario
    {
        public string Fecha { get; set; } = null!;
        public string Usuario { get; set; } = null!;
        public int IdenDiasusuarios { get; set; }
    }
}
