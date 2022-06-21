using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class EscenariosRetencione
    {
        public EscenariosRetencione()
        {
            EscenariosDocumentosLineasDetalles = new HashSet<EscenariosDocumentosLineasDetalle>();
            EscenariosEscenarioRetenciones = new HashSet<EscenariosEscenarioRetencione>();
            EscenariosRetencionesMoneda = new HashSet<EscenariosRetencionesMoneda>();
        }

        public decimal Iden { get; set; }
        public string Codigo { get; set; } = null!;
        public string Nombre { get; set; } = null!;
        public string? EscenariosTipoTasaIden { get; set; }
        public string? EscenariosConceptoRetencionIden { get; set; }
        public string ValorBase { get; set; } = null!;
        public decimal BaseMinima { get; set; }
        public int Redondeo { get; set; }
        public bool? PermiteRedondear { get; set; }

        public virtual EscenariosConceptoRetencion? EscenariosConceptoRetencionIdenNavigation { get; set; }
        public virtual EscenariosTipoTasa? EscenariosTipoTasaIdenNavigation { get; set; }
        public virtual ICollection<EscenariosDocumentosLineasDetalle> EscenariosDocumentosLineasDetalles { get; set; }
        public virtual ICollection<EscenariosEscenarioRetencione> EscenariosEscenarioRetenciones { get; set; }
        public virtual ICollection<EscenariosRetencionesMoneda> EscenariosRetencionesMoneda { get; set; }
    }
}
