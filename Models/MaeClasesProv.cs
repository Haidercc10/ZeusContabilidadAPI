using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class MaeClasesProv
    {
        public MaeClasesProv()
        {
            Proveedores = new HashSet<Proveedore>();
        }

        public int Iden { get; set; }
        public string Codigo { get; set; } = null!;
        public string Descripcion { get; set; } = null!;
        public int Deshabilitado { get; set; }
        public byte[] VersionDeLaFila { get; set; } = null!;
        public string? CodBienServicio { get; set; }

        public virtual ICollection<Proveedore> Proveedores { get; set; }
    }
}
