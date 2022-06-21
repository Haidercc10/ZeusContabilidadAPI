using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class MfProfesion
    {
        public MfProfesion()
        {
            MfEmpleados = new HashSet<MfEmpleado>();
            MfFamilia = new HashSet<MfFamilium>();
        }

        public int IdProfesion { get; set; }
        public string Codprofesion { get; set; } = null!;
        public string Nombre { get; set; } = null!;

        public virtual ICollection<MfEmpleado> MfEmpleados { get; set; }
        public virtual ICollection<MfFamilium> MfFamilia { get; set; }
    }
}
