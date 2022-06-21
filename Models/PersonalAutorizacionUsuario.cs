using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class PersonalAutorizacionUsuario
    {
        public int Iden { get; set; }
        public string Personal { get; set; } = null!;
        public int Opcion { get; set; }
        public string Usuario { get; set; } = null!;
    }
}
