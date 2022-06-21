using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class CfactModeloH
    {
        public CfactModeloH()
        {
            CfactModeloBs = new HashSet<CfactModeloB>();
        }

        public string Codigo { get; set; } = null!;
        public string Descripcion { get; set; } = null!;
        public string Tipo { get; set; } = null!;
        public int IdenCfactModeloh { get; set; }

        public virtual ICollection<CfactModeloB> CfactModeloBs { get; set; }
    }
}
