using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class Divpolitica
    {
        public Divpolitica()
        {
            Clientes = new HashSet<Cliente>();
            Proveedores = new HashSet<Proveedore>();
            Terceros = new HashSet<Tercero>();
        }

        public string Iddivpolitica { get; set; } = null!;
        public string Desdivpolitica { get; set; } = null!;
        public string? Codigodane { get; set; }
        public byte Nivdivpolitica { get; set; }
        public string Depdivpolitica { get; set; } = null!;
        public DateTime? Fecdivpolitica { get; set; }
        public int? Ncddivpolitica { get; set; }
        public string? Tipodivpolitica { get; set; }
        public int Deshabilitado { get; set; }
        public byte[] VersionDeLaFila { get; set; } = null!;
        public int IdenDivpolitica { get; set; }

        public virtual ICollection<Cliente> Clientes { get; set; }
        public virtual ICollection<Proveedore> Proveedores { get; set; }
        public virtual ICollection<Tercero> Terceros { get; set; }
    }
}
