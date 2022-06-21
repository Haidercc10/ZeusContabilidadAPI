using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class Paise
    {
        public Paise()
        {
            Clientes = new HashSet<Cliente>();
            EscenariosDocumentos = new HashSet<EscenariosDocumento>();
            EscenariosImpuestosPais = new HashSet<EscenariosImpuestosPai>();
            Proveedores = new HashSet<Proveedore>();
            Terceros = new HashSet<Tercero>();
        }

        public string Codigo { get; set; } = null!;
        public string Descripcion { get; set; } = null!;
        public int Deshabilitado { get; set; }
        public decimal IdenPais { get; set; }
        public byte[] VersionDeLaFila { get; set; } = null!;

        public virtual ICollection<Cliente> Clientes { get; set; }
        public virtual ICollection<EscenariosDocumento> EscenariosDocumentos { get; set; }
        public virtual ICollection<EscenariosImpuestosPai> EscenariosImpuestosPais { get; set; }
        public virtual ICollection<Proveedore> Proveedores { get; set; }
        public virtual ICollection<Tercero> Terceros { get; set; }
    }
}
