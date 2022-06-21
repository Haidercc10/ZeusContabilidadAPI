using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class EscenariosImpuestosPai
    {
        public EscenariosImpuestosPai()
        {
            EscenariosImpuestosPaisMoneda = new HashSet<EscenariosImpuestosPaisMoneda>();
        }

        public decimal Iden { get; set; }
        public decimal EscenariosImpuestosIden { get; set; }
        public decimal EscenariosPaisIden { get; set; }
        public string TipoAplicacionImpuestoIden { get; set; } = null!;
        public bool? ImpuestoPagado { get; set; }
        public decimal? Porcentaje { get; set; }
        public string? ConceptoDbId { get; set; }
        public string? ConceptoCrId { get; set; }
        public int? Redondeo { get; set; }
        public DateTime? FechaEfectiva { get; set; }
        public DateTime? FechaModificacion { get; set; }
        public decimal? PorcentajeResultante { get; set; }
        public bool? PermiteRedondear { get; set; }

        public virtual EscenariosImpuesto EscenariosImpuestosIdenNavigation { get; set; } = null!;
        public virtual Paise EscenariosPaisIdenNavigation { get; set; } = null!;
        public virtual EscenariosTipoAplicacionImpuesto TipoAplicacionImpuestoIdenNavigation { get; set; } = null!;
        public virtual ICollection<EscenariosImpuestosPaisMoneda> EscenariosImpuestosPaisMoneda { get; set; }
    }
}
