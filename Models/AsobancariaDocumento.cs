using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class AsobancariaDocumento
    {
        public decimal? Consecutivo { get; set; }
        public string? DocumentoInicial { get; set; }
        public string? DocumentoFinal { get; set; }
        public string? CodigoEmpresa { get; set; }
        public string? NumeroCuentaAfiliado { get; set; }
        public string? EntidadRecaudadora { get; set; }
        public decimal? RegistrosLeidos { get; set; }
        public decimal? ValorLeido { get; set; }
        public decimal? RegistrosProcesados { get; set; }
        public decimal? ValorProcesado { get; set; }
        public int IdenAsobancariaDocumento { get; set; }
    }
}
