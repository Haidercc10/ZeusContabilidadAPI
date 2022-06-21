using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class EsquemaDatosPlantilla
    {
        public decimal IdenEsquema { get; set; }
        public int IdenPlanillaCampo { get; set; }
        public string? Valor { get; set; }
        public int IdenEsquemaDatosplantilla { get; set; }

        public virtual Esquema IdenEsquemaNavigation { get; set; } = null!;
        public virtual EsquemaPlantillaCampo IdenPlanillaCampoNavigation { get; set; } = null!;
    }
}
