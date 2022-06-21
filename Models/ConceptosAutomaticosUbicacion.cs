using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class ConceptosAutomaticosUbicacion
    {
        public decimal IdenConceptoAuto { get; set; }
        public string CodigoUbicacion { get; set; } = null!;
        public string CodigoUbicacionUsuario { get; set; } = null!;
        public int IdenConceptosautomaticosubicacion { get; set; }

        public virtual Ubicaciongeografica CodigoUbicacionNavigation { get; set; } = null!;
        public virtual Ubicaciongeografica CodigoUbicacionUsuarioNavigation { get; set; } = null!;
        public virtual ConceptosAutomatico IdenConceptoAutoNavigation { get; set; } = null!;
    }
}
