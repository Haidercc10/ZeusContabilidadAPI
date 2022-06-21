using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class MaeTipodeEvento
    {
        public MaeTipodeEvento()
        {
            MaeventosIs = new HashSet<MaeventosI>();
        }

        public string Codigo { get; set; } = null!;
        public string? Nombre { get; set; }
        public string? Descripcion { get; set; }
        public int IdenMaetipodeeventos { get; set; }

        public virtual ICollection<MaeventosI> MaeventosIs { get; set; }
    }
}
