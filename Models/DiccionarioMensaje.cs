using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class DiccionarioMensaje
    {
        public string Idioma { get; set; } = null!;
        public int CodigoMensaje { get; set; }
        public short Nivel { get; set; }
        public string Mensaje { get; set; } = null!;
        public string? Modulo { get; set; }
        public int IdenDiccionarioMensajes { get; set; }
    }
}
