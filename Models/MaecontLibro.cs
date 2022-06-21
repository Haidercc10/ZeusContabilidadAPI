using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class MaecontLibro
    {
        public decimal Id { get; set; }
        public string? Codicta { get; set; }
        public decimal? IdenLibro { get; set; }
        public string? DescripcionLibro { get; set; }
        public string? CodictaLibro { get; set; }
        public string? IdmonedaLibro { get; set; }
        public string? CodictaGananciaLibro { get; set; }
        public string? CodictaPerdidaLibro { get; set; }
        public string? TasaAjusteLibro { get; set; }
        public int DeshabilitadaLibro { get; set; }
    }
}
