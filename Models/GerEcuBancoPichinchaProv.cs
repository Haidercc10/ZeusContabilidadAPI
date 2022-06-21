using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class GerEcuBancoPichinchaProv
    {
        public string? CodProveedor { get; set; }
        public string CodTercero { get; set; } = null!;
        public string TipoIdentificacion { get; set; } = null!;
        public string FormaPago { get; set; } = null!;
        public string TipoCuenta { get; set; } = null!;
        public string NumeroCuenta { get; set; } = null!;
        public string Moneda { get; set; } = null!;
        public string LocalidadPago { get; set; } = null!;
        public string CodigoBancoSpi { get; set; } = null!;
        public string? CodigoTercero { get; set; }
        public string? TipoMatricula { get; set; }
        public string Mostrar { get; set; } = null!;
        public string CodigoMatricula { get; set; } = null!;
        public int Principal { get; set; }
        public int IdenGerecubancopichinchaProv { get; set; }
    }
}
