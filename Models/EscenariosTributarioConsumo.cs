using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class EscenariosTributarioConsumo
    {
        public EscenariosTributarioConsumo()
        {
            EscenariosDocumentosLineas = new HashSet<EscenariosDocumentosLinea>();
            EscenariosFiscales = new HashSet<EscenariosFiscale>();
        }

        public decimal Iden { get; set; }
        public string Codigo { get; set; } = null!;
        public string Nombre { get; set; } = null!;
        public decimal? ValorFijo { get; set; }

        public virtual ICollection<EscenariosDocumentosLinea> EscenariosDocumentosLineas { get; set; }
        public virtual ICollection<EscenariosFiscale> EscenariosFiscales { get; set; }
    }
}
