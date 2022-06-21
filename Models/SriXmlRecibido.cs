using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class SriXmlRecibido
    {
        public decimal Iden { get; set; }
        public string Estado { get; set; } = null!;
        public string NumeroAutorizacion { get; set; } = null!;
        public string FechaAutorizacion { get; set; } = null!;
        public string Ambiente { get; set; } = null!;
        public string RutaXml { get; set; } = null!;
        public DateTime FechaLectura { get; set; }
        public bool Procesado { get; set; }
    }
}
