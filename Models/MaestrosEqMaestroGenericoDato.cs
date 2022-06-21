using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class MaestrosEqMaestroGenericoDato
    {
        public string MaestroGenerico { get; set; } = null!;
        public string Codigo { get; set; } = null!;
        public string? Nombre { get; set; }
        public int IdenMaestroseqMaestrogenericoDatos { get; set; }

        public virtual MaestrosEqMaestrosGenerico MaestroGenericoNavigation { get; set; } = null!;
    }
}
