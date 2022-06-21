using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class EsquemaPlantilla
    {
        public EsquemaPlantilla()
        {
            EsquemaPlantillaCampos = new HashSet<EsquemaPlantillaCampo>();
            Esquemas = new HashSet<Esquema>();
        }

        public int Iden { get; set; }
        public string Codigo { get; set; } = null!;
        public string Nombre { get; set; } = null!;
        public string? Descripcion { get; set; }
        public decimal? IdenEsquemaPlantilla { get; set; }
        public int Deshabilitado { get; set; }

        public virtual Esquema? IdenEsquemaPlantillaNavigation { get; set; }
        public virtual ICollection<EsquemaPlantillaCampo> EsquemaPlantillaCampos { get; set; }
        public virtual ICollection<Esquema> Esquemas { get; set; }
    }
}
