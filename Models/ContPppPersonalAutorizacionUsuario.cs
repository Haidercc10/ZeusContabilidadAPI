using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class ContPppPersonalAutorizacionUsuario
    {
        public string Usuario { get; set; } = null!;
        public string UsuarioAutorizado { get; set; } = null!;
        public int IdenContPppPersonalautorizacionUsuarios { get; set; }
    }
}
