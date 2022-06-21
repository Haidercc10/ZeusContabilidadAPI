using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class MaquinasHost
    {
        public MaquinasHost()
        {
            ResolucionVsMaquinas = new HashSet<ResolucionVsMaquina>();
        }

        public decimal Iden { get; set; }
        public string Nombre { get; set; } = null!;
        public string Descripcion { get; set; } = null!;
        public string Serial { get; set; } = null!;
        public string Ubicacion { get; set; } = null!;
        public bool Deshabilitado { get; set; }

        public virtual ICollection<ResolucionVsMaquina> ResolucionVsMaquinas { get; set; }
    }
}
