using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class Maeunid
    {
        public Maeunid()
        {
            MaecontUniadic1Navigations = new HashSet<Maecont>();
            MaecontUniadic2Navigations = new HashSet<Maecont>();
            MaecontUniadic3Navigations = new HashSet<Maecont>();
            MfPresupuestos = new HashSet<MfPresupuesto>();
        }

        public string Idunidad { get; set; } = null!;
        public string Nombunidad { get; set; } = null!;
        public string Abrevunid { get; set; } = null!;
        public string Tipounidad { get; set; } = null!;
        public int Deshabilitado { get; set; }
        public byte[] VersionDeLaFila { get; set; } = null!;
        public int IdenMaeunid { get; set; }

        public virtual ICollection<Maecont> MaecontUniadic1Navigations { get; set; }
        public virtual ICollection<Maecont> MaecontUniadic2Navigations { get; set; }
        public virtual ICollection<Maecont> MaecontUniadic3Navigations { get; set; }
        public virtual ICollection<MfPresupuesto> MfPresupuestos { get; set; }
    }
}
