using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class MaestrosEqMaestrosGenerico
    {
        public MaestrosEqMaestrosGenerico()
        {
            MaestrosEqMaestroGenericoDatos = new HashSet<MaestrosEqMaestroGenericoDato>();
        }

        public string TipoMaestro { get; set; } = null!;
        public string MaestroGenerico { get; set; } = null!;
        public string? Nombre { get; set; }
        public int IdenMaestroseqMaestrosgenericos { get; set; }

        public virtual MaestrosEqTipoMaestro TipoMaestroNavigation { get; set; } = null!;
        public virtual ICollection<MaestrosEqMaestroGenericoDato> MaestrosEqMaestroGenericoDatos { get; set; }
    }
}
