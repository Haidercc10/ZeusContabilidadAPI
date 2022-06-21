using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class UsuariosModificaFecha
    {
        public string Usuario { get; set; } = null!;
        public string IdTipDoc { get; set; } = null!;
        public int IdenUsuariosModificafecha { get; set; }

        public virtual Tipodcto IdTipDocNavigation { get; set; } = null!;
        public virtual Usuario1 UsuarioNavigation { get; set; } = null!;
    }
}
