using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class ClasificacionAnticiposCuenta
    {
        public int IdClasificacionAnticipos { get; set; }
        public string Codicta { get; set; } = null!;
        public int IdenClasificacionanticiposcuentas { get; set; }

        public virtual Maecont CodictaNavigation { get; set; } = null!;
        public virtual ClasificacionAnticipo IdClasificacionAnticiposNavigation { get; set; } = null!;
    }
}
