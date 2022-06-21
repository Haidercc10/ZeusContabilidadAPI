using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class Segmento
    {
        public Segmento()
        {
            Clientes = new HashSet<Cliente>();
            Proveedores = new HashSet<Proveedore>();
            Terceros = new HashSet<Tercero>();
        }

        public string Idsegmento { get; set; } = null!;
        public string Dessegmento { get; set; } = null!;
        public byte Nivsegmento { get; set; }
        public string Depsegmento { get; set; } = null!;
        public DateTime? Fecsegmento { get; set; }
        public int? Ncdsegmento { get; set; }
        public string? Tiposegmento { get; set; }
        public int Deshabilitado { get; set; }
        public byte[] VersionDeLaFila { get; set; } = null!;
        public int IdenSegmento { get; set; }

        public virtual ICollection<Cliente> Clientes { get; set; }
        public virtual ICollection<Proveedore> Proveedores { get; set; }
        public virtual ICollection<Tercero> Terceros { get; set; }
    }
}
