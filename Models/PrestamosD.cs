using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class PrestamosD
    {
        public decimal IdPrestamoD { get; set; }
        public decimal IdPrestamoG { get; set; }
        public int NumCuotas { get; set; }
        public string Vencimiento { get; set; } = null!;
        public decimal? VrCapital { get; set; }
        public decimal? VrInteres { get; set; }
        public string? FechaCausacion { get; set; }
        public string? FuenteCausacion { get; set; }
        public string? DocumentoCausacion { get; set; }
        public decimal CausacionEstudio { get; set; }
        public decimal CausacionSeguros { get; set; }
        public decimal CausacionCapacitacion { get; set; }
        public decimal CausacionComision { get; set; }

        public virtual PrestamosG IdPrestamoGNavigation { get; set; } = null!;
    }
}
