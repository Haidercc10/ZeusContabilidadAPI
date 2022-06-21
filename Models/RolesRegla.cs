using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class RolesRegla
    {
        public RolesRegla()
        {
            RolesEntidadesNivel1s = new HashSet<RolesEntidadesNivel1>();
            RolesReglasdelRols = new HashSet<RolesReglasdelRol>();
        }

        public decimal Iden { get; set; }
        public string Codigo { get; set; } = null!;
        public string? Nombre { get; set; }
        public string? Descripcion { get; set; }
        public string? TipoRegla { get; set; }
        public string? ObjetoValidacion { get; set; }
        public string? Formula { get; set; }
        public int? Niveles { get; set; }
        public string? EntidadNivel1 { get; set; }
        public string? EntidadNivel2 { get; set; }
        public string? EntidadNivel3 { get; set; }
        public string? EntidadNivel4 { get; set; }
        public string? EntidadNivel5 { get; set; }

        public virtual RolesObjetosValidacion? ObjetoValidacionNavigation { get; set; }
        public virtual RolesTipoRegla? TipoReglaNavigation { get; set; }
        public virtual ICollection<RolesEntidadesNivel1> RolesEntidadesNivel1s { get; set; }
        public virtual ICollection<RolesReglasdelRol> RolesReglasdelRols { get; set; }
    }
}
