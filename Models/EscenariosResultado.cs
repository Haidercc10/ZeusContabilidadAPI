using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class EscenariosResultado
    {
        public decimal Iden { get; set; }
        public int Spid { get; set; }
        public string? Linea { get; set; }
        public string? SubLinea { get; set; }
        public string? ImpuestoRetencion { get; set; }
        public string? TipoImpuesto { get; set; }
        public int? MayorValor { get; set; }
        public string? Cuenta { get; set; }
        public decimal? Valor { get; set; }
        public decimal? Porcentaje { get; set; }
        public decimal? Base { get; set; }
    }
}
