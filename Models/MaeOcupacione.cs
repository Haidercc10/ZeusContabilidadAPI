using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class MaeOcupacione
    {
        public string Codigo { get; set; } = null!;
        public string Descripcion { get; set; } = null!;
        public string Cargo { get; set; } = null!;
        public int IdenMaeOcupaciones { get; set; }
        public byte[] VersionDeLaFila { get; set; } = null!;
    }
}
