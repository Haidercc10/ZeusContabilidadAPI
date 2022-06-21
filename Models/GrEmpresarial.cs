using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class GrEmpresarial
    {
        public GrEmpresarial()
        {
            Clientes = new HashSet<Cliente>();
            Proveedores = new HashSet<Proveedore>();
        }

        public string CodigoGrEmpresarial { get; set; } = null!;
        public string Nombre { get; set; } = null!;
        public byte? Nivel { get; set; }
        public string? Pertenece { get; set; }
        public DateTime? Fecha { get; set; }
        public int? Ncd { get; set; }
        public string? Tipo { get; set; }
        public int Deshabilitado { get; set; }
        public decimal CupoCliPrv { get; set; }
        public int IdenGrempresarial { get; set; }
        public byte[] VersionDeLaFila { get; set; } = null!;

        public virtual ICollection<Cliente> Clientes { get; set; }
        public virtual ICollection<Proveedore> Proveedores { get; set; }
    }
}
