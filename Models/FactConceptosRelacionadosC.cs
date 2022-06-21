using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class FactConceptosRelacionadosC
    {
        public string ConceptoPadre { get; set; } = null!;
        public string ConceptoHijo { get; set; } = null!;
        public int IdenFactconceptosrelacionadosc { get; set; }
    }
}
