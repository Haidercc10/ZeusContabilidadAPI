using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class GerBanBoliviaBisaProveedor
    {
        public string? IdProveedor { get; set; }
        public string? IdTercero { get; set; }
        public string? TipoMatricula { get; set; }
        public int? Principal { get; set; }
        public string? CodigoMatricula { get; set; }
        public string? TipoDocumento { get; set; }
        public string? NumeroDocumento { get; set; }
        public string? TipoPersona { get; set; }
        public int? EsEmpleado { get; set; }
        public string? Telefono { get; set; }
        public string? Email { get; set; }
        public string? TipoCuenta { get; set; }
        public string? Cuenta { get; set; }
        public string? Banco { get; set; }
        public string? Sucursal { get; set; }
        public string? TipoBenef { get; set; }
        public string? Beneficiario { get; set; }
        public string? FormaEntrega { get; set; }
        public string? NombreCompleto { get; set; }
        public string? ApellidoMaterno { get; set; }
        public string? CodigoTercero { get; set; }
        public int IdenGerbanboliviabisaProveedor { get; set; }

        public virtual GerBanBoliviaBisaBanco? BancoNavigation { get; set; }
        public virtual Tercero? CodigoTerceroNavigation { get; set; }
        public virtual Tercero? IdTerceroNavigation { get; set; }
        public virtual GerBanBoliviaBisaSucursal? SucursalNavigation { get; set; }
        public virtual GerBanBoliviaBisaTiposId? TipoDocumentoNavigation { get; set; }
    }
}
