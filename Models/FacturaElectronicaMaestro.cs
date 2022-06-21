using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class FacturaElectronicaMaestro
    {
        public FacturaElectronicaMaestro()
        {
            FacturaElectronicaMaestroDatos = new HashSet<FacturaElectronicaMaestroDato>();
        }

        public string Codigo { get; set; } = null!;
        public string Nombre { get; set; } = null!;
        public int IdenFacturaelectronicaMaestros { get; set; }

        public virtual ICollection<FacturaElectronicaMaestroDato> FacturaElectronicaMaestroDatos { get; set; }
    }
}
