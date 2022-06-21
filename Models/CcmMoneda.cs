using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class CcmMoneda
    {
        public string CodigoMoneda { get; set; } = null!;
        public string DescripcionMoneda { get; set; } = null!;
        public byte? TipoMoneda { get; set; }
        public decimal? ProcentajeComisión { get; set; }
        public string? CuentaComisión { get; set; }
        public string? MedioDePago { get; set; }
        public string? Topico1 { get; set; }
        public decimal? PorcentajeTopico1 { get; set; }
        public string? CuentaContableTopico1 { get; set; }
        public string DependeTopico1 { get; set; } = null!;
        public string? Topico2 { get; set; }
        public decimal? PorcentajeTopico2 { get; set; }
        public string? CuentaContableTopico2 { get; set; }
        public string DependeTopico2 { get; set; } = null!;
        public string? Topico3 { get; set; }
        public decimal? PorcentajeTopico3 { get; set; }
        public string? CuentaContableTopico3 { get; set; }
        public string DependeTopico3 { get; set; } = null!;
        public string? Topico4 { get; set; }
        public decimal? PorcentajeTopico4 { get; set; }
        public string? CuentaContableTopico4 { get; set; }
        public string DependeTopico4 { get; set; } = null!;
        public string? Topico5 { get; set; }
        public decimal? PorcentajeTopico5 { get; set; }
        public string? CuentaContableTopico5 { get; set; }
        public string DependeTopico5 { get; set; } = null!;
        public string Deshabilitado { get; set; } = null!;
        public int DecimalesEnAfectacionContable { get; set; }
        public int DecimalesEnModuloImpuesto { get; set; }
    }
}
