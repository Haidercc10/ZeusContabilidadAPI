using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class GerBancoBbvaperuProv
    {
        public string? CodProveedor { get; set; }
        public string CodTercero { get; set; } = null!;
        public string TipoIdentificacion { get; set; } = null!;
        public string TipoAbono { get; set; } = null!;
        public string Cuenta { get; set; } = null!;
        public string Oficina { get; set; } = null!;
        public string DigitosControl { get; set; } = null!;
        public bool IndicadorAviso { get; set; }
        public string? TipoMedioAviso { get; set; }
        public string? MedioAviso { get; set; }
        public string? CodigoTercero { get; set; }
        public string? TipoMatricula { get; set; }
        public string CodigoMatricula { get; set; } = null!;
        public int Principal { get; set; }
        public string Cci { get; set; } = null!;
        public int Moneda { get; set; }
        public bool Habilitado { get; set; }
        public int IdenGerbancobbvaperuProv { get; set; }
        public string? IdBanco { get; set; }

        public virtual Banco? IdBancoNavigation { get; set; }
    }
}
