using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class GerCreditoPeruProv
    {
        public string? CodProveedor { get; set; }
        public string CodTercero { get; set; } = null!;
        public string TipoRegistro { get; set; } = null!;
        public string TipoProducto { get; set; } = null!;
        public string Sucursal { get; set; } = null!;
        public string Codigo { get; set; } = null!;
        public string Moneda { get; set; } = null!;
        public string Digito { get; set; } = null!;
        public string TipoIdentificacion { get; set; } = null!;
        public string TipoDcto { get; set; } = null!;
        public string TipoAbono { get; set; } = null!;
        public int ValidarRuc { get; set; }
        public string Direccion { get; set; } = null!;
        public string Distrito { get; set; } = null!;
        public string Provincia { get; set; } = null!;
        public string Departamento { get; set; } = null!;
        public string Contacto { get; set; } = null!;
        public string? CodigoTercero { get; set; }
        public string? TipoMatricula { get; set; }
        public string CodigoMatricula { get; set; } = null!;
        public int Principal { get; set; }
        public string Cci { get; set; } = null!;
        public int MonedaGerencia { get; set; }
        public bool Habilitado { get; set; }
        public int IdenGercreditoperuProv { get; set; }
        public string? IdBanco { get; set; }

        public virtual Proveedore? CodProveedorNavigation { get; set; }
        public virtual Tercero? CodigoTerceroNavigation { get; set; }
        public virtual Banco? IdBancoNavigation { get; set; }
    }
}
