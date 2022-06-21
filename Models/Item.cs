using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class Item
    {
        public Item()
        {
            Clientes = new HashSet<Cliente>();
            Proveedores = new HashSet<Proveedore>();
            SaldoitemsBus = new HashSet<SaldoitemsBu>();
            Terceros = new HashSet<Tercero>();
        }

        public string Iditem { get; set; } = null!;
        public string Descrip { get; set; } = null!;
        public byte? Nivitem { get; set; }
        public string? Depitem { get; set; }
        public DateTime? Fecitem { get; set; }
        public int? Ncditem { get; set; }
        public string? Tipoitem { get; set; }
        public int Deshabilitado { get; set; }
        public byte[] VersionDeLaFila { get; set; } = null!;
        public int IdenItems { get; set; }

        public virtual ICollection<Cliente> Clientes { get; set; }
        public virtual ICollection<Proveedore> Proveedores { get; set; }
        public virtual ICollection<SaldoitemsBu> SaldoitemsBus { get; set; }
        public virtual ICollection<Tercero> Terceros { get; set; }
    }
}
