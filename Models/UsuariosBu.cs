using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class UsuariosBu
    {
        public string Usuario { get; set; } = null!;
        public string Bu { get; set; } = null!;
        public int IdenUsuariosBu { get; set; }

        public virtual Bu BuNavigation { get; set; } = null!;
        public virtual Usuario1 UsuarioNavigation { get; set; } = null!;
    }
}
