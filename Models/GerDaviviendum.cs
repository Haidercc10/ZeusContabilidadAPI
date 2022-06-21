using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class GerDaviviendum
    {
        public string CodTercero { get; set; } = null!;
        public string TipoIdentificacion { get; set; } = null!;
        public string CodBanco { get; set; } = null!;
        public string CodBancoGer { get; set; } = null!;
        public string Cuenta { get; set; } = null!;
        public string TipoCuenta { get; set; } = null!;
        public string CodSubServicio { get; set; } = null!;
        public string DigVerificacion { get; set; } = null!;
        public int IdenGerdavivienda { get; set; }

        public virtual Banco CodBancoNavigation { get; set; } = null!;
        public virtual Tercero CodTerceroNavigation { get; set; } = null!;
    }
}
