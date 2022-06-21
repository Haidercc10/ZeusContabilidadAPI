using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class AplicacionesZeu
    {
        public AplicacionesZeu()
        {
            MaestrosEqTipoMaestros = new HashSet<MaestrosEqTipoMaestro>();
        }

        public int Id { get; set; }
        public string Nombre { get; set; } = null!;
        public byte Habilitar { get; set; }
        public byte BlBack { get; set; }
        public byte BlFront { get; set; }
        public int IdenAplicacioneszeus { get; set; }

        public virtual ICollection<MaestrosEqTipoMaestro> MaestrosEqTipoMaestros { get; set; }
    }
}
