using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class Certificadodisponibilidad
    {
        public decimal Certificado { get; set; }
        public string? Ano { get; set; }
        public string? Codpresu { get; set; }
        public string? Cenco { get; set; }
        public DateTime? Fecha { get; set; }
        public decimal? Apropiacion { get; set; }
        public decimal? Dispexpedidas { get; set; }
        public decimal? Saldoapropiacion { get; set; }
        public decimal? Valordisponibilidad { get; set; }
        public decimal? Nuevosaldoaprop { get; set; }
        public string? Descripcion { get; set; }
        public string? Ordencompra { get; set; }
        public decimal? Saldocertificado { get; set; }
    }
}
