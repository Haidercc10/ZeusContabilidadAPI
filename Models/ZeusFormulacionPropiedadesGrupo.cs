using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class ZeusFormulacionPropiedadesGrupo
    {
        public string Propiedad { get; set; } = null!;
        public string Grupo { get; set; } = null!;
        public int IdenZeusformulacionpropiedadesgrupos { get; set; }

        public virtual ZeusFormulacionGrupo GrupoNavigation { get; set; } = null!;
        public virtual ZeusFormulacionPropiedade PropiedadNavigation { get; set; } = null!;
    }
}
