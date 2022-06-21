using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class EscenariosEscenarioRetencione
    {
        public decimal Iden { get; set; }
        public decimal EscenariosEscenarioIden { get; set; }
        public decimal EscenariosRetencionesIden { get; set; }
        public decimal PorcentajeDeLaBase { get; set; }
        public string Naturaleza { get; set; } = null!;
        public decimal Porcentaje { get; set; }
        public string? ConceptoCrId { get; set; }
        public string? ConceptoDbId { get; set; }
        public DateTime? FechaEfectiva { get; set; }
        public bool? PermitirManual { get; set; }

        public virtual EscenariosEscenario EscenariosEscenarioIdenNavigation { get; set; } = null!;
        public virtual EscenariosRetencione EscenariosRetencionesIdenNavigation { get; set; } = null!;
    }
}
