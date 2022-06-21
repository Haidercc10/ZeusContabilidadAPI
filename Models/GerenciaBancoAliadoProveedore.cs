using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class GerenciaBancoAliadoProveedore
    {
        public string? CodProveedor { get; set; }
        public string CodTercero { get; set; } = null!;
        public string CodBanco { get; set; } = null!;
        public string Cuenta { get; set; } = null!;
        public string TipoCuenta { get; set; } = null!;
        public string Mostrar { get; set; } = null!;
        public string? CodigoTercero { get; set; }
        public string? TipoMatricula { get; set; }
        public string CodigoMatricula { get; set; } = null!;
        public int Principal { get; set; }
        public int IdenGerenciaBancoaliadoProveedores { get; set; }
    }
}
