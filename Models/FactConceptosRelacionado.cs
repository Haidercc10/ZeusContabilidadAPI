using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class FactConceptosRelacionado
    {
        public string ConceptoPadre { get; set; } = null!;
        public string ConceptoHijo { get; set; } = null!;
        public string TipoTercero { get; set; } = null!;
        public string Tercero { get; set; } = null!;
        public string TipoAuxiliar { get; set; } = null!;
        public string Auxiliar { get; set; } = null!;
        public int IdenFactconceptosrelacionados { get; set; }

        public virtual Factconc ConceptoHijoNavigation { get; set; } = null!;
        public virtual Factconc ConceptoPadreNavigation { get; set; } = null!;
    }
}
