using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class GerBancoBbvaperu
    {
        public string CodTercero { get; set; } = null!;
        public string Cuenta { get; set; } = null!;
        public string Oficina { get; set; } = null!;
        public string DigitosControl { get; set; } = null!;
        public string TipoProceso { get; set; } = null!;
        public string HoraProceso { get; set; } = null!;
        public bool ValidaPertenencia { get; set; }
        public int IdenGerbancobbvaperu { get; set; }
        public string? IdBanco { get; set; }

        public virtual Banco? IdBancoNavigation { get; set; }
    }
}
