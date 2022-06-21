using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class UsuariosPermisoDcto
    {
        public string Usuario { get; set; } = null!;
        public string Idfuente { get; set; } = null!;
        public int IndReversionTra { get; set; }
        public int IndModificacionDcto { get; set; }
        public int IdenUsuariosPermisodcto { get; set; }

        public virtual Fuente IdfuenteNavigation { get; set; } = null!;
        public virtual Usuario1 UsuarioNavigation { get; set; } = null!;
    }
}
