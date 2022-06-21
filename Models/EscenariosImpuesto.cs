using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class EscenariosImpuesto
    {
        public EscenariosImpuesto()
        {
            EscenariosDocumentosLineaEscenariosImpuestosIden1Navigations = new HashSet<EscenariosDocumentosLinea>();
            EscenariosDocumentosLineaEscenariosImpuestosIden2Navigations = new HashSet<EscenariosDocumentosLinea>();
            EscenariosDocumentosLineaEscenariosImpuestosIden3Navigations = new HashSet<EscenariosDocumentosLinea>();
            EscenariosDocumentosLineaEscenariosImpuestosIden4Navigations = new HashSet<EscenariosDocumentosLinea>();
            EscenariosDocumentosLineaEscenariosImpuestosIden5Navigations = new HashSet<EscenariosDocumentosLinea>();
            EscenariosDocumentosLineasDetalles = new HashSet<EscenariosDocumentosLineasDetalle>();
            EscenariosFiscalesImpuestos = new HashSet<EscenariosFiscalesImpuesto>();
            EscenariosImpuestosPais = new HashSet<EscenariosImpuestosPai>();
        }

        public decimal Iden { get; set; }
        public string Codigo { get; set; } = null!;
        public string Nombre { get; set; } = null!;
        public string? VchTipo { get; set; }
        public string? CategoriaIden { get; set; }
        public string? CompraVenta { get; set; }
        public bool? ChkValorFijo { get; set; }

        public virtual EscenariosCategoriaImpuesto? CategoriaIdenNavigation { get; set; }
        public virtual ICollection<EscenariosDocumentosLinea> EscenariosDocumentosLineaEscenariosImpuestosIden1Navigations { get; set; }
        public virtual ICollection<EscenariosDocumentosLinea> EscenariosDocumentosLineaEscenariosImpuestosIden2Navigations { get; set; }
        public virtual ICollection<EscenariosDocumentosLinea> EscenariosDocumentosLineaEscenariosImpuestosIden3Navigations { get; set; }
        public virtual ICollection<EscenariosDocumentosLinea> EscenariosDocumentosLineaEscenariosImpuestosIden4Navigations { get; set; }
        public virtual ICollection<EscenariosDocumentosLinea> EscenariosDocumentosLineaEscenariosImpuestosIden5Navigations { get; set; }
        public virtual ICollection<EscenariosDocumentosLineasDetalle> EscenariosDocumentosLineasDetalles { get; set; }
        public virtual ICollection<EscenariosFiscalesImpuesto> EscenariosFiscalesImpuestos { get; set; }
        public virtual ICollection<EscenariosImpuestosPai> EscenariosImpuestosPais { get; set; }
    }
}
