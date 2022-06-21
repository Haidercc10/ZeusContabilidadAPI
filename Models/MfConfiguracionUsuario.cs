using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class MfConfiguracionUsuario
    {
        public string IdUsuario { get; set; } = null!;
        public string Password { get; set; } = null!;
        public int Comite { get; set; }
        public int RvComite { get; set; }
        public int PinvSinCodeudor { get; set; }
        public int PgrSinCodeudor { get; set; }
        public int PgenPagare { get; set; }
        public int PanuPagare { get; set; }
        public int PactPagare { get; set; }
        public int IdenMfConfiguracionusuarios { get; set; }

        public virtual Usuario1 IdUsuarioNavigation { get; set; } = null!;
    }
}
