using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class GerBogotum
    {
        public string CodTercero { get; set; } = null!;
        public string TipoIdentificacion { get; set; } = null!;
        public string Cuenta { get; set; } = null!;
        public string TipoCuenta { get; set; } = null!;
        public string Oficina { get; set; } = null!;
        public string Ciudad { get; set; } = null!;
        public string DigVerificacion { get; set; } = null!;
        public int IdenGerbogota { get; set; }

        public virtual Tercero CodTerceroNavigation { get; set; } = null!;
    }
}
