using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class PersonalAutorizacion
    {
        public string Usuario { get; set; } = null!;
        public string Firma { get; set; } = null!;
        public int BloqueoCliente { get; set; }
        public int IdenPersonalautorizacion { get; set; }

        public virtual Usuario1 UsuarioNavigation { get; set; } = null!;
    }
}
