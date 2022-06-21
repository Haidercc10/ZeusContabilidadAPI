using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class AmbitosFiscalesUsuario
    {
        public string Login { get; set; } = null!;
        public string CodigoUbicacion { get; set; } = null!;
        public int IdenAmbitosfiscalesusuarios { get; set; }

        public virtual Usuario1 LoginNavigation { get; set; } = null!;
    }
}
