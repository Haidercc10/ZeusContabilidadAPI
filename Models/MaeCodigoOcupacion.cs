using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class MaeCodigoOcupacion
    {
        public long Iden { get; set; }
        public string Codigo { get; set; } = null!;
        public string Descripcion { get; set; } = null!;
        public int Nivel { get; set; }
        public string Tipo { get; set; } = null!;
        public string Depende { get; set; } = null!;
        public int Ndependientes { get; set; }
        public int Deshabilitado { get; set; }
        public byte[] VersionDeLaFila { get; set; } = null!;
    }
}
