using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class MfParentesco
    {
        public MfParentesco()
        {
            MfFamilia = new HashSet<MfFamilium>();
        }

        public decimal IdParentesco { get; set; }
        public string Codparentesco { get; set; } = null!;
        public string Nombre { get; set; } = null!;

        public virtual ICollection<MfFamilium> MfFamilia { get; set; }
    }
}
