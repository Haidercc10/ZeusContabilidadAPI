using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class Ger14proveedore
    {
        public string? IdProveedor { get; set; }
        public string IdTercero { get; set; } = null!;
        public string Telefono { get; set; } = null!;
        public string Fax { get; set; } = null!;
        public string IdBanco { get; set; } = null!;
        public string Cuenta { get; set; } = null!;
        public string TipoCuenta { get; set; } = null!;
        public string Mostrar { get; set; } = null!;
        public string Departamento { get; set; } = null!;
        public string Sigla { get; set; } = null!;
        public string NombreResponsable { get; set; } = null!;
        public string CargoResponsable { get; set; } = null!;
        public string? CodigoTercero { get; set; }
        public string? TipoMatricula { get; set; }
        public int? TipoIdentificacion { get; set; }
        public string? Identificacion { get; set; }
        public string? CodDpto { get; set; }
        public string? CodCiudad { get; set; }
        public string? CodPais { get; set; }
        public string? Email { get; set; }
        public string? Oficial { get; set; }
        public string CodigoMatricula { get; set; } = null!;
        public int Principal { get; set; }
        public int IdenGer14proveedores { get; set; }

        public virtual Tercero? CodigoTerceroNavigation { get; set; }
        public virtual Banco IdBancoNavigation { get; set; } = null!;
        public virtual Proveedore? IdProveedorNavigation { get; set; }
    }
}
