using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class ZeusExcelSentenciaParametro
    {
        public int Id { get; set; }
        public int SentenciaId { get; set; }
        public string? Parametro { get; set; }
        public bool? IsValorDefecto { get; set; }
        public string? HojaValor { get; set; }
        public string? Celda { get; set; }
        public string? DescripcionCampo { get; set; }
        public int? Orden { get; set; }
        public string? Observacion { get; set; }
        public string? Ayuda { get; set; }

        public virtual ZeusExcelSentencia Sentencia { get; set; } = null!;
    }
}
