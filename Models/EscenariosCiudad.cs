using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class EscenariosCiudad
    {
        public EscenariosCiudad()
        {
            EscenariosDocumentosLineas = new HashSet<EscenariosDocumentosLinea>();
            EscenariosProveedores = new HashSet<EscenariosProveedore>();
            EscenariosTributarioIcatCiudads = new HashSet<EscenariosTributarioIcatCiudad>();
        }

        public decimal Iden { get; set; }
        public string Codigo { get; set; } = null!;
        public string Nombre { get; set; } = null!;

        public virtual ICollection<EscenariosDocumentosLinea> EscenariosDocumentosLineas { get; set; }
        public virtual ICollection<EscenariosProveedore> EscenariosProveedores { get; set; }
        public virtual ICollection<EscenariosTributarioIcatCiudad> EscenariosTributarioIcatCiudads { get; set; }
    }
}
