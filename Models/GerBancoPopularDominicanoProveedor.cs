using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class GerBancoPopularDominicanoProveedor
    {
        public string? IdProveedor { get; set; }
        public string? Identificacion { get; set; }
        public string? TipoMatricula { get; set; }
        public string? Banco { get; set; }
        public string? Cuenta { get; set; }
        public string? TipoCuenta { get; set; }
        public string? Moneda { get; set; }
        public string? TipoContacto { get; set; }
        public string? CodOperacion { get; set; }
        public DateTime? Vencimiento { get; set; }
        public string? CodigoMatricula { get; set; }
        public int? Principal { get; set; }
        public int IdenGerbancopopulardominicanoProveedor { get; set; }

        public virtual GerBancoPopularDominicanoBanco? BancoNavigation { get; set; }
        public virtual Proveedore? IdProveedorNavigation { get; set; }
        public virtual Tercero? IdentificacionNavigation { get; set; }
    }
}
