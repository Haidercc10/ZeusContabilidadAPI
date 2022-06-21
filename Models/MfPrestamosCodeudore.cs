using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class MfPrestamosCodeudore
    {
        public string Codprestamo { get; set; } = null!;
        public string CodCodeudor { get; set; } = null!;
        public string EstudioCodeudor { get; set; } = null!;
        public string CodUsuario { get; set; } = null!;
        public int IdenMfPrestamoscodeudores { get; set; }
    }
}
