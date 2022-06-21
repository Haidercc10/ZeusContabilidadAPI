using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class MfTiponegocio
    {
        public MfTiponegocio()
        {
            MfTablapadres = new HashSet<MfTablapadre>();
        }

        public int IdTiponeg { get; set; }
        public string Codtiponeg { get; set; } = null!;
        public string Nombre { get; set; } = null!;

        public virtual ICollection<MfTablapadre> MfTablapadres { get; set; }
    }
}
