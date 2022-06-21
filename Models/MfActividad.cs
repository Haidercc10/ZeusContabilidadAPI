using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class MfActividad
    {
        public MfActividad()
        {
            MfDatosusuarioadis = new HashSet<MfDatosusuarioadi>();
            MfRenovacionCreditos = new HashSet<MfRenovacionCredito>();
        }

        public int IdActividad { get; set; }
        public string CodActividad { get; set; } = null!;
        public string Nombre { get; set; } = null!;
        public string Sector { get; set; } = null!;
        public string Descripcion { get; set; } = null!;

        public virtual ICollection<MfDatosusuarioadi> MfDatosusuarioadis { get; set; }
        public virtual ICollection<MfRenovacionCredito> MfRenovacionCreditos { get; set; }
    }
}
