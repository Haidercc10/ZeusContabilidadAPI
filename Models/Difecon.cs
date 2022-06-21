using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class Difecon
    {
        public string Iddif { get; set; } = null!;
        public string Codigodif { get; set; } = null!;
        public string? Cencosdif { get; set; }
        public string? Auxiliadif { get; set; }
        public string? Itemdif { get; set; }
        public string? Tercerdif { get; set; }
        public decimal? Porcedif { get; set; }
        public decimal? Valordif { get; set; }
        public string? CliPrv { get; set; }
        public string? TipoFac { get; set; }
        public string? Numefac { get; set; }
        public string? Vencefac { get; set; }
        public string? Refefac { get; set; }
        public string TipoVcto { get; set; } = null!;
        public string VenceCada { get; set; } = null!;
        public string PeriodicidadVcto { get; set; } = null!;
        public bool ValidaDiaFestivos { get; set; }
        public string? CodigoPropiedad1 { get; set; }
        public string? CodigoPropiedad2 { get; set; }
        public string? CodigoPropiedad3 { get; set; }
        public string? CodigoPropiedad4 { get; set; }
        public string? CodigoPropiedad5 { get; set; }
        public string? Revelacion { get; set; }
        public int? IdenSecciones { get; set; }
        public int IdenDifecon { get; set; }
        public string? Bu { get; set; }
        public string CodigoPresupuestal { get; set; } = null!;
        public string ReservaPresupuestal { get; set; } = null!;
        public string TipoTrans { get; set; } = null!;

        public virtual Maecont CodigodifNavigation { get; set; } = null!;
        public virtual Difepar IddifNavigation { get; set; } = null!;
    }
}
