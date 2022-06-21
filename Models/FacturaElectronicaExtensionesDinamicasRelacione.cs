using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class FacturaElectronicaExtensionesDinamicasRelacione
    {
        public decimal Iden { get; set; }
        public decimal ExtensionDinamicaIden { get; set; }
        public string CampoJoin { get; set; } = null!;
        public string CampoVista { get; set; } = null!;

        public virtual FacturaElectronicaExtensionesDinamica ExtensionDinamicaIdenNavigation { get; set; } = null!;
    }
}
