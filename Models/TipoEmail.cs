using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class TipoEmail
    {
        public TipoEmail()
        {
            TipoEmailDatos = new HashSet<TipoEmailDato>();
        }

        public decimal Iden { get; set; }
        public string Codigo { get; set; } = null!;
        public string Nombre { get; set; } = null!;
        public decimal IdTipoEmailMaestros { get; set; }

        public virtual TipoEmailMaestro IdTipoEmailMaestrosNavigation { get; set; } = null!;
        public virtual ICollection<TipoEmailDato> TipoEmailDatos { get; set; }
    }
}
