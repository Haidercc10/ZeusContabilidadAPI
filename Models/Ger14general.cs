using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class Ger14general
    {
        public string IdTercero { get; set; } = null!;
        public string IdBanco { get; set; } = null!;
        public string Cuenta { get; set; } = null!;
        public string TipoCuenta { get; set; } = null!;
        public string DigVerificacion { get; set; } = null!;
        public string MostrarFacturas { get; set; } = null!;
        public int? TipoIdentificacion { get; set; }
        public string? CaracteresEspeciales { get; set; }
        public int IdenGer14general { get; set; }

        public virtual Banco IdBancoNavigation { get; set; } = null!;
        public virtual Tercero IdTerceroNavigation { get; set; } = null!;
    }
}
