using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class TipoMaestro
    {
        public int Iden { get; set; }
        public string Nombre { get; set; } = null!;
        public string? Detalles { get; set; }
        public string Sp { get; set; } = null!;
        public bool VentanaEspecial { get; set; }
        public string VentanaTitulo { get; set; } = null!;
        public int VentanaAncho { get; set; }
        public int VentanaAlto { get; set; }
        public string SeccionIni { get; set; } = null!;
        public int Tipo { get; set; }
        public string? Reporte { get; set; }
    }
}
