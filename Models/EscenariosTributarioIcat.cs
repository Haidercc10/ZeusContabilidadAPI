using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class EscenariosTributarioIcat
    {
        public EscenariosTributarioIcat()
        {
            EscenariosDocumentosLineas = new HashSet<EscenariosDocumentosLinea>();
            EscenariosFiscales = new HashSet<EscenariosFiscale>();
            EscenariosTributarioIcatCiudads = new HashSet<EscenariosTributarioIcatCiudad>();
        }

        public decimal Iden { get; set; }
        public string Codigo { get; set; } = null!;
        public string Nombre { get; set; } = null!;

        public virtual ICollection<EscenariosDocumentosLinea> EscenariosDocumentosLineas { get; set; }
        public virtual ICollection<EscenariosFiscale> EscenariosFiscales { get; set; }
        public virtual ICollection<EscenariosTributarioIcatCiudad> EscenariosTributarioIcatCiudads { get; set; }
    }
}
