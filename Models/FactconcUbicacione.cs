using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class FactconcUbicacione
    {
        public string Concepto { get; set; } = null!;
        public string CodigoUbicacion { get; set; } = null!;
        public string CodigoUbicacionUsuario { get; set; } = null!;
        public int IdenFactconcUbicaciones { get; set; }

        public virtual Ubicaciongeografica CodigoUbicacionNavigation { get; set; } = null!;
        public virtual Ubicaciongeografica CodigoUbicacionUsuarioNavigation { get; set; } = null!;
        public virtual Factconc ConceptoNavigation { get; set; } = null!;
    }
}
