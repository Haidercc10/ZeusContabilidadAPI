using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class Grupusua
    {
        public string Grupo { get; set; } = null!;
        public short Ubicacion { get; set; }
        public int IdenGrupusua { get; set; }
    }
}
