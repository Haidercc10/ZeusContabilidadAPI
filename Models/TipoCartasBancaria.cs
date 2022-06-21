using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class TipoCartasBancaria
    {
        public int Iden { get; set; }
        public string? Codigo { get; set; }
        public string? Descripcion { get; set; }
        public string? FormatoImpresion { get; set; }
        public bool Deshabilitado { get; set; }
    }
}
