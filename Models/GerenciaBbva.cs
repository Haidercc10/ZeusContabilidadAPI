using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class GerenciaBbva
    {
        public decimal Id { get; set; }
        public string? CodProveedor { get; set; }
        public string TipoId { get; set; } = null!;
        public string NumeroId { get; set; } = null!;
        public string DigitoControlId { get; set; } = null!;
        public string FormaPago { get; set; } = null!;
        public string Banco { get; set; } = null!;
        public string Cuenta { get; set; } = null!;
        public string Oficina { get; set; } = null!;
        public string CuentaNacha { get; set; } = null!;
        public string TipoCuenta { get; set; } = null!;
        public string TipoCuentaBbva { get; set; } = null!;
        public string? CodigoTercero { get; set; }
        public string? TipoMatricula { get; set; }
        public string CodigoMatricula { get; set; } = null!;
        public int Principal { get; set; }

        public virtual Proveedore? CodProveedorNavigation { get; set; }
        public virtual Tercero? CodigoTerceroNavigation { get; set; }
    }
}
