using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class Ubicaciongeografica
    {
        public Ubicaciongeografica()
        {
            Clientes = new HashSet<Cliente>();
            ConceptosAutomaticosUbicacionCodigoUbicacionNavigations = new HashSet<ConceptosAutomaticosUbicacion>();
            ConceptosAutomaticosUbicacionCodigoUbicacionUsuarioNavigations = new HashSet<ConceptosAutomaticosUbicacion>();
            FactconcUbicacioneCodigoUbicacionNavigations = new HashSet<FactconcUbicacione>();
            FactconcUbicacioneCodigoUbicacionUsuarioNavigations = new HashSet<FactconcUbicacione>();
            Proveedores = new HashSet<Proveedore>();
        }

        public string Codigoubicacion { get; set; } = null!;
        public string Nombre { get; set; } = null!;
        public byte? Nivel { get; set; }
        public string? Pertenece { get; set; }
        public DateTime? Fecha { get; set; }
        public int? Ncd { get; set; }
        public string? Tipo { get; set; }
        public int Deshabilitado { get; set; }
        public byte[] VersionDeLaFila { get; set; } = null!;
        public int IdenUbicaciongeografica { get; set; }

        public virtual ICollection<Cliente> Clientes { get; set; }
        public virtual ICollection<ConceptosAutomaticosUbicacion> ConceptosAutomaticosUbicacionCodigoUbicacionNavigations { get; set; }
        public virtual ICollection<ConceptosAutomaticosUbicacion> ConceptosAutomaticosUbicacionCodigoUbicacionUsuarioNavigations { get; set; }
        public virtual ICollection<FactconcUbicacione> FactconcUbicacioneCodigoUbicacionNavigations { get; set; }
        public virtual ICollection<FactconcUbicacione> FactconcUbicacioneCodigoUbicacionUsuarioNavigations { get; set; }
        public virtual ICollection<Proveedore> Proveedores { get; set; }
    }
}
