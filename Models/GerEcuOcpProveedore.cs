using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class GerEcuOcpProveedore
    {
        public string? Idproveedor { get; set; }
        public string Idtercero { get; set; } = null!;
        public string Localidad { get; set; } = null!;
        public string TipoCuenta { get; set; } = null!;
        public string NumeroCuenta { get; set; } = null!;
        public string FormaPago { get; set; } = null!;
        public string Moneda { get; set; } = null!;
        public string AgenciaRetiro { get; set; } = null!;
        public string TipoIdentificacion { get; set; } = null!;
        public string Telefono { get; set; } = null!;
        public string Entidad { get; set; } = null!;
        public string LocalidadRetiro { get; set; } = null!;
        public string Codigo { get; set; } = null!;
        public string CodigoServicio { get; set; } = null!;
        public string CuentaOb { get; set; } = null!;
        public string? CodigoTercero { get; set; }
        public string? TipoMatricula { get; set; }
        public string CodigoMatricula { get; set; } = null!;
        public int Principal { get; set; }
        public int IdenGerecuOcpProveedores { get; set; }

        public virtual Tercero? CodigoTerceroNavigation { get; set; }
        public virtual Proveedore? IdproveedorNavigation { get; set; }
    }
}
