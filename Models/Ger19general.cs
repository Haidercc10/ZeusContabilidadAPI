using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class Ger19general
    {
        public string CodTercero { get; set; } = null!;
        public string Clave { get; set; } = null!;
        public string Cuenta { get; set; } = null!;
        public string Oficina { get; set; } = null!;
        public string Fecha { get; set; } = null!;
        public int Cantidad { get; set; }
        public string Medida { get; set; } = null!;
        public int IdenGer19general { get; set; }
        public bool BlDigitoVerificacion { get; set; }

        public virtual Tercero CodTerceroNavigation { get; set; } = null!;
    }
}
