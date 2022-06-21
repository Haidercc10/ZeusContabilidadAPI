using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class EsquemaPlantillaCampo
    {
        public EsquemaPlantillaCampo()
        {
            EsquemaDatosPlantillas = new HashSet<EsquemaDatosPlantilla>();
        }

        public int Iden { get; set; }
        public int IdenPlanilla { get; set; }
        public string Campo { get; set; } = null!;
        public string? Descripcion { get; set; }

        public virtual EsquemaPlantilla IdenPlanillaNavigation { get; set; } = null!;
        public virtual ICollection<EsquemaDatosPlantilla> EsquemaDatosPlantillas { get; set; }
    }
}
