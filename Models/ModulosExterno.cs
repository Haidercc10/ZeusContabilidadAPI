using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class ModulosExterno
    {
        public int Codigo { get; set; }
        public string Nombre { get; set; } = null!;
        public string? Detalles { get; set; }
        public string SeccionServidorIni { get; set; } = null!;
        public string SeccionBaseIni { get; set; } = null!;
        public string? Parametr { get; set; }
        public int IdenModulosexternos { get; set; }
    }
}
