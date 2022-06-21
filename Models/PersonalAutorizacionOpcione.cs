using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class PersonalAutorizacionOpcione
    {
        public string? Usuario { get; set; }
        public int? IdMenu { get; set; }
        public int IdenPersonalautorizacionOpciones { get; set; }

        public virtual Menu? IdMenuNavigation { get; set; }
        public virtual PersonalAutorizacion? UsuarioNavigation { get; set; }
    }
}
