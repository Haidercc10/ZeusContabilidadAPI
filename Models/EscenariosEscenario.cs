using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class EscenariosEscenario
    {
        public EscenariosEscenario()
        {
            EscenariosDocumentosLineas = new HashSet<EscenariosDocumentosLinea>();
            EscenariosEscenarioRetenciones = new HashSet<EscenariosEscenarioRetencione>();
            EscenariosFiscales = new HashSet<EscenariosFiscale>();
        }

        public decimal Iden { get; set; }
        public string Codigo { get; set; } = null!;
        public string Nombre { get; set; } = null!;
        public bool? PermitirManual { get; set; }

        public virtual ICollection<EscenariosDocumentosLinea> EscenariosDocumentosLineas { get; set; }
        public virtual ICollection<EscenariosEscenarioRetencione> EscenariosEscenarioRetenciones { get; set; }
        public virtual ICollection<EscenariosFiscale> EscenariosFiscales { get; set; }
    }
}
