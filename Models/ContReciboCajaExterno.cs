using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class ContReciboCajaExterno
    {
        public decimal Id { get; set; }
        public DateTime? FechaGrabacion { get; set; }
        public string? Cliente { get; set; }
        public string? Fecha { get; set; }
        public string? Fuente { get; set; }
        public string? Serie { get; set; }
        public string? Descripcion { get; set; }
        public string? XmlFacturas { get; set; }
        public string? XmlPagos { get; set; }
        public string? Usuario { get; set; }
        public string? DocumentoGenerado { get; set; }
        public string? MensajeError { get; set; }
    }
}
