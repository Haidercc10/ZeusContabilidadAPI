using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class GerBancoFalabellaProveedore
    {
        public decimal Iden { get; set; }
        public string? CodigoProveedor { get; set; }
        public string CodigoTercero { get; set; } = null!;
        public string TipoMatricula { get; set; } = null!;
        public string CodigoMatricula { get; set; } = null!;
        public bool? BlPrincipal { get; set; }
        public string Banco { get; set; } = null!;
        public string TipoCuenta { get; set; } = null!;
        public string NumeroCuenta { get; set; } = null!;
        public string Referencia { get; set; } = null!;
        public string TipoIdentificacion { get; set; } = null!;
        public string NumeroIdentificacion { get; set; } = null!;
        public string Correo { get; set; } = null!;

        public virtual Proveedore? CodigoProveedorNavigation { get; set; }
        public virtual Tercero CodigoTerceroNavigation { get; set; } = null!;
    }
}
