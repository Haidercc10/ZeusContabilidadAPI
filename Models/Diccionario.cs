using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class Diccionario
    {
        public string Tabla { get; set; } = null!;
        public string Campo { get; set; } = null!;
        public short Tamano { get; set; }
        public string Tipo { get; set; } = null!;
        public string? Idtabla { get; set; }
        public string? Idcampo { get; set; }
        public string? Descripcion { get; set; }
        public bool? Mostrar { get; set; }
        public int IdenDiccionario { get; set; }
    }
}
