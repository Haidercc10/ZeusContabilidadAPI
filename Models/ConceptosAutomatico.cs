using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class ConceptosAutomatico
    {
        public ConceptosAutomatico()
        {
            ConceptosAutomaticosUbicacions = new HashSet<ConceptosAutomaticosUbicacion>();
        }

        public decimal Iden { get; set; }
        public string CategoriaFiscal { get; set; } = null!;
        public string Concepto { get; set; } = null!;

        public virtual TiposDeEmpresa CategoriaFiscalNavigation { get; set; } = null!;
        public virtual Factconc ConceptoNavigation { get; set; } = null!;
        public virtual ICollection<ConceptosAutomaticosUbicacion> ConceptosAutomaticosUbicacions { get; set; }
    }
}
