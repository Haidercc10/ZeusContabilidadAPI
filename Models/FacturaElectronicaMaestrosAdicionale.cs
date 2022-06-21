using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class FacturaElectronicaMaestrosAdicionale
    {
        public int Iden { get; set; }
        public string Facturador { get; set; } = null!;
        public string Maestro { get; set; } = null!;
        public string MaestroCodigo { get; set; } = null!;
        public string NombreMaestroHijo { get; set; } = null!;
        public string Codigo { get; set; } = null!;
        public string Nombre { get; set; } = null!;
        public string? Desc1 { get; set; }
        public string? Desc2 { get; set; }
        public string? Desc3 { get; set; }
        public string? Desc4 { get; set; }
        public string? Desc5 { get; set; }
        public int Deshabilitado { get; set; }
    }
}
