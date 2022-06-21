using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class RolesParametrosEntradum
    {
        public RolesParametrosEntradum()
        {
            RolesObjetosValidacionParametrosEntrada = new HashSet<RolesObjetosValidacionParametrosEntrada>();
        }

        public string Codigo { get; set; } = null!;
        public string? Nombre { get; set; }
        public string? NombreIdentificador { get; set; }
        public string? Descripcion { get; set; }
        public string? TipoDeDatos { get; set; }
        public string? Tamaño { get; set; }
        public string? PresentacionZeusFormulacion { get; set; }
        public string? Categoria { get; set; }
        public int IdenRolesparametrosentrada { get; set; }

        public virtual ICollection<RolesObjetosValidacionParametrosEntrada> RolesObjetosValidacionParametrosEntrada { get; set; }
    }
}
