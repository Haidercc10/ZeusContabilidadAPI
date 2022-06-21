using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class MfNivelescolaridad
    {
        public MfNivelescolaridad()
        {
            MfDatosusuarioadis = new HashSet<MfDatosusuarioadi>();
            MfFamilia = new HashSet<MfFamilium>();
        }

        public decimal IdNivelesc { get; set; }
        public string Codnivelesc { get; set; } = null!;
        public string Nombre { get; set; } = null!;

        public virtual ICollection<MfDatosusuarioadi> MfDatosusuarioadis { get; set; }
        public virtual ICollection<MfFamilium> MfFamilia { get; set; }
    }
}
