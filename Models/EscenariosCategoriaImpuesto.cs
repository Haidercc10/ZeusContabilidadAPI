using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class EscenariosCategoriaImpuesto
    {
        public EscenariosCategoriaImpuesto()
        {
            EscenariosImpuestos = new HashSet<EscenariosImpuesto>();
        }

        public string Iden { get; set; } = null!;
        public string Nombre { get; set; } = null!;
        public int IdenEscenariosCategoriaimpuesto { get; set; }

        public virtual ICollection<EscenariosImpuesto> EscenariosImpuestos { get; set; }
    }
}
