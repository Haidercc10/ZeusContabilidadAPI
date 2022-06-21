using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class ConfiguracionEmail
    {
        public string CorreoEntrante { get; set; } = null!;
        public string CorreoSaliente { get; set; } = null!;
        public string Usuario { get; set; } = null!;
        public string Contraseña { get; set; } = null!;
        public string Login { get; set; } = null!;
        public int Autenticar { get; set; }
        public string Puerto { get; set; } = null!;
        public int EnableSsl { get; set; }
        public int ConfirmacionLectura { get; set; }
        public string EmailCopiaSeguridad { get; set; } = null!;
        public int IdenConfiguracionemail { get; set; }
    }
}
