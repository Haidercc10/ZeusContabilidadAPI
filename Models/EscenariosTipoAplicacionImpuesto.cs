using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class EscenariosTipoAplicacionImpuesto
    {
        public EscenariosTipoAplicacionImpuesto()
        {
            EscenariosImpuestosPais = new HashSet<EscenariosImpuestosPai>();
        }

        public string Iden { get; set; } = null!;
        public string Nombre { get; set; } = null!;
        public int IdenEscenariosTipoaplicacionimpuesto { get; set; }

        public virtual ICollection<EscenariosImpuestosPai> EscenariosImpuestosPais { get; set; }
    }
}
