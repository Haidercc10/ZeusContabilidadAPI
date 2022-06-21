using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class FacturaElectronicaExtensionesDinamicasMapeo
    {
        public decimal Iden { get; set; }
        public string Codigo { get; set; } = null!;
        public string CampoVista { get; set; } = null!;
    }
}
