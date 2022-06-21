using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class DocumentXmlAdicionalesLog
    {
        public decimal Iden { get; set; }
        public string? Fntedcto { get; set; }
        public string? Numedcto { get; set; }
        public string? XmlAdicionales { get; set; }
        public DateTime? FechaGrabacion { get; set; }
    }
}
