using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class CfactAsignaModelo
    {
        public string IdProveedor { get; set; } = null!;
        public string Documento { get; set; } = null!;
        public string IdModelo { get; set; } = null!;
        public string FechaInicio { get; set; } = null!;
        public int Periodicidad { get; set; }
        public int? NumeroPeriodos { get; set; }
        public int? PeriodoControl { get; set; }
        public int? Estado { get; set; }
        public string? FechaFact { get; set; }
        public string? IdFuente { get; set; }
        public string? IdDocumento { get; set; }
        public decimal? UltimoVrFacturado { get; set; }
        public string? CentroCosto { get; set; }
        public string? Ciclo { get; set; }
        public string Bu { get; set; } = null!;
        public string? CxP { get; set; }
        public string? Item { get; set; }
        public string? CodigoPropiedad1 { get; set; }
        public string? CodigoPropiedad2 { get; set; }
        public string? CodigoPropiedad3 { get; set; }
        public string? CodigoPropiedad4 { get; set; }
        public string? CodigoPropiedad5 { get; set; }
        public int IdenCfactAsignamodelo { get; set; }

        public virtual Bu BuNavigation { get; set; } = null!;
    }
}
