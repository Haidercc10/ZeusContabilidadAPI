using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class ContIfLogCambio
    {
        public decimal Id { get; set; }
        public decimal? IdAnterior { get; set; }
        public decimal? IdNuevo { get; set; }
        public string? Fecha { get; set; }
        public string? Fuente { get; set; }
        public string? Documento { get; set; }
        public string? Descripcion { get; set; }
        public string? Usuario { get; set; }
        public DateTime? FechaGrabacion { get; set; }
    }
}
