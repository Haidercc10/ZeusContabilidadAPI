using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class EscenariosCategoriaTributarium
    {
        public EscenariosCategoriaTributarium()
        {
            EscenariosDocumentosLineas = new HashSet<EscenariosDocumentosLinea>();
            EscenariosFiscales = new HashSet<EscenariosFiscale>();
        }

        public string Iden { get; set; } = null!;
        public string Nombre { get; set; } = null!;
        public int IdenEscenariosCategoriatributaria { get; set; }

        public virtual ICollection<EscenariosDocumentosLinea> EscenariosDocumentosLineas { get; set; }
        public virtual ICollection<EscenariosFiscale> EscenariosFiscales { get; set; }
    }
}
