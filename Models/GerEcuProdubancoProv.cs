using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class GerEcuProdubancoProv
    {
        public string? IdProve { get; set; }
        public string IdTercero { get; set; } = null!;
        public string Cuenta { get; set; } = null!;
        public string? Moneda { get; set; }
        public string? FormaPago { get; set; }
        public string? TipoCuenta { get; set; }
        public string? NombreProveedor { get; set; }
        public string? Direccion { get; set; }
        public string? Telefono { get; set; }
        public string? LocalidadPago { get; set; }
        public string? Email { get; set; }
        public string? Institucion { get; set; }
        public string? Identificacion { get; set; }
        public string? Ciudad { get; set; }
        public bool? Enviaremal { get; set; }
        public string? CodigoTercero { get; set; }
        public string? TipoMatricula { get; set; }
        public string CodigoMatricula { get; set; } = null!;
        public int Principal { get; set; }
        public int IdenGerecuProdubancoProv { get; set; }

        public virtual Tercero? CodigoTerceroNavigation { get; set; }
        public virtual Proveedore? IdProveNavigation { get; set; }
    }
}
