using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class MaestrosEqTipoMaestro
    {
        public MaestrosEqTipoMaestro()
        {
            MaestrosEqMaestrosGenericos = new HashSet<MaestrosEqMaestrosGenerico>();
        }

        public string Codigo { get; set; } = null!;
        public string SeccionIni { get; set; } = null!;
        public string Ini { get; set; } = null!;
        public int? IdAplicacionesZeus { get; set; }
        public int IdenMaestroseqTipomaestros { get; set; }

        public virtual AplicacionesZeu? IdAplicacionesZeusNavigation { get; set; }
        public virtual ICollection<MaestrosEqMaestrosGenerico> MaestrosEqMaestrosGenericos { get; set; }
    }
}
