using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class EscenariosConceptoRetencion
    {
        public EscenariosConceptoRetencion()
        {
            EscenariosRetenciones = new HashSet<EscenariosRetencione>();
        }

        public string Iden { get; set; } = null!;
        public string Nombre { get; set; } = null!;
        public int IdenEscenariosConceptoretencion { get; set; }

        public virtual ICollection<EscenariosRetencione> EscenariosRetenciones { get; set; }
    }
}
