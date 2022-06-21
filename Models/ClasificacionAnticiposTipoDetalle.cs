using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class ClasificacionAnticiposTipoDetalle
    {
        public int IdClasificacionAnticiposTipo { get; set; }
        public int IdClasificacionAnticipos { get; set; }
        public int IdenClasificacionanticipostipodetalle { get; set; }

        public virtual ClasificacionAnticipo IdClasificacionAnticiposNavigation { get; set; } = null!;
        public virtual ClasificacionAnticiposTipo IdClasificacionAnticiposTipoNavigation { get; set; } = null!;
    }
}
