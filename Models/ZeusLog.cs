using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class ZeusLog
    {
        public decimal Id { get; set; }
        public string Evento { get; set; } = null!;
        public decimal? Usuario { get; set; }
        public string? Login { get; set; }
        public string? Host { get; set; }
        public DateTime Fecha { get; set; }
        public string? Descripcion { get; set; }
        public string? DescripcionRtf { get; set; }
        public string? DescripcionHtml { get; set; }
        public int? IdenMotivo { get; set; }
        public string? DescripcionMotivo { get; set; }
    }
}
