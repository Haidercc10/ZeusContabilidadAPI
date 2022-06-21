using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class FacturaElectronicaTipoMaestro
    {
        public string Codigo { get; set; } = null!;
        public string SeccionIni { get; set; } = null!;
        public string Ini { get; set; } = null!;
        public int? IdAplicacionesZeus { get; set; }
        public int IdenFacturaelectronicaTipomaestros { get; set; }
        public string? CodigoBuscador { get; set; }
        public string? ColumnaDescripcionMaestro { get; set; }
        public string? Descripcion { get; set; }

        public virtual AplicacionesZeu? IdAplicacionesZeusNavigation { get; set; }
    }
}
