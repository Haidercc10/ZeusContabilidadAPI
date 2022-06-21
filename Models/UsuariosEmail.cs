using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class UsuariosEmail
    {
        public decimal IdUsuario { get; set; }
        public int IdEmailConfig { get; set; }
        public int IdenUsuariosemail { get; set; }

        public virtual ZeusFwEmailConfig IdEmailConfigNavigation { get; set; } = null!;
        public virtual Usuario1 IdUsuarioNavigation { get; set; } = null!;
    }
}
