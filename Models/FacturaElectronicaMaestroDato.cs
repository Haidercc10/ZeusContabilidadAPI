using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class FacturaElectronicaMaestroDato
    {
        public string MaestroCodigo { get; set; } = null!;
        public string Codigo { get; set; } = null!;
        public string Nombre { get; set; } = null!;
        public string? Depende { get; set; }
        public int IdenFacturaelectronicaMaestroDatos { get; set; }

        public virtual FacturaElectronicaMaestro MaestroCodigoNavigation { get; set; } = null!;
    }
}
