using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class TiposDeEmpresa
    {
        public TiposDeEmpresa()
        {
            CombinacionTiposEmpresaTipoEmpresaExternaNavigations = new HashSet<CombinacionTiposEmpresa>();
            CombinacionTiposEmpresaTipoEmpresaLocalNavigations = new HashSet<CombinacionTiposEmpresa>();
            ConceptosAutomaticos = new HashSet<ConceptosAutomatico>();
            Terceros = new HashSet<Tercero>();
        }

        public string TipoEmpresa { get; set; } = null!;
        public string Nombre { get; set; } = null!;
        public string Descripcion { get; set; } = null!;
        public decimal Monto { get; set; }
        public int Deshabilitado { get; set; }
        public byte[] VersionDeLaFila { get; set; } = null!;
        public int IdenTiposdeempresa { get; set; }

        public virtual ICollection<CombinacionTiposEmpresa> CombinacionTiposEmpresaTipoEmpresaExternaNavigations { get; set; }
        public virtual ICollection<CombinacionTiposEmpresa> CombinacionTiposEmpresaTipoEmpresaLocalNavigations { get; set; }
        public virtual ICollection<ConceptosAutomatico> ConceptosAutomaticos { get; set; }
        public virtual ICollection<Tercero> Terceros { get; set; }
    }
}
