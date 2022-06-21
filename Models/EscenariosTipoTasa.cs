using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class EscenariosTipoTasa
    {
        public EscenariosTipoTasa()
        {
            EscenariosRetenciones = new HashSet<EscenariosRetencione>();
        }

        public string Iden { get; set; } = null!;
        public string Nombre { get; set; } = null!;
        public int IdenEscenariosTipotasa { get; set; }

        public virtual ICollection<EscenariosRetencione> EscenariosRetenciones { get; set; }
    }
}
