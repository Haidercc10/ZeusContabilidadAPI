using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class FacturasIntNovedade
    {
        public decimal Iden { get; set; }
        public string Bu { get; set; } = null!;
        public string Codicta { get; set; } = null!;
        public string Idcliprv { get; set; } = null!;
        public string Tipofac { get; set; } = null!;
        public string Numefac { get; set; } = null!;
        public string Vencefac { get; set; } = null!;
        public string Refefac { get; set; } = null!;
        public decimal Saldo { get; set; }
        public string Idfuente { get; set; } = null!;
        public string Numdoctra { get; set; } = null!;
        public string Fechacausacion { get; set; } = null!;
        public decimal Intereses { get; set; }
        public int Consecutra { get; set; }
        public string Fechainicial { get; set; } = null!;
        public string Fechafinal { get; set; } = null!;
        public double? Porcentaje { get; set; }
        public double? Spread { get; set; }
        public double? LogSpread { get; set; }
        public string? LogtipoSpread { get; set; }
        public string? Logtipotasa { get; set; }
        public double? LogPorcentaje { get; set; }
        public decimal? LogIdenTasaVariable { get; set; }
    }
}
