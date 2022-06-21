using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class ZeusExcelSentenciaCampo
    {
        public int Id { get; set; }
        public int SentenciaId { get; set; }
        public string? Campo { get; set; }
        public bool? Mostrar { get; set; }
        public string? DescripcionCampo { get; set; }
        public int? Orden { get; set; }

        public virtual ZeusExcelSentencia Sentencia { get; set; } = null!;
    }
}
