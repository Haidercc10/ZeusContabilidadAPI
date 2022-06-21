using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class Maecco
    {
        public Maecco()
        {
            Clientes = new HashSet<Cliente>();
            Factconcs = new HashSet<Factconc>();
            ImpExtractosCodMovimientos = new HashSet<ImpExtractosCodMovimiento>();
            MaeccoCuenta = new HashSet<MaeccoCuenta>();
            Proveedores = new HashSet<Proveedore>();
            SaldoccoBus = new HashSet<SaldoccoBu>();
            Terceros = new HashSet<Tercero>();
        }

        public string Idcenco { get; set; } = null!;
        public string Descenco { get; set; } = null!;
        public byte Nivcenco { get; set; }
        public string Depcenco { get; set; } = null!;
        public DateTime? Feccenco { get; set; }
        public int? Ncdcenco { get; set; }
        public string? Tipocenco { get; set; }
        public int Deshabilitado { get; set; }
        public byte[] VersionDeLaFila { get; set; } = null!;
        public int IdenMaecco { get; set; }

        public virtual ZiNomIntegraCco ZiNomIntegraCco { get; set; } = null!;
        public virtual ICollection<Cliente> Clientes { get; set; }
        public virtual ICollection<Factconc> Factconcs { get; set; }
        public virtual ICollection<ImpExtractosCodMovimiento> ImpExtractosCodMovimientos { get; set; }
        public virtual ICollection<MaeccoCuenta> MaeccoCuenta { get; set; }
        public virtual ICollection<Proveedore> Proveedores { get; set; }
        public virtual ICollection<SaldoccoBu> SaldoccoBus { get; set; }
        public virtual ICollection<Tercero> Terceros { get; set; }
    }
}
