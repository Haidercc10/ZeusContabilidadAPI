using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class Saldogeneral
    {
        public string Bu { get; set; } = null!;
        public string Anomescta { get; set; } = null!;
        public string Codicta { get; set; } = null!;
        public string Idunidad { get; set; } = null!;
        public string Idtercero { get; set; } = null!;
        public string Idcenco { get; set; } = null!;
        public string Auxiaux { get; set; } = null!;
        public string Idcliprv { get; set; } = null!;
        public string Tipofact { get; set; } = null!;
        public string Numefac { get; set; } = null!;
        public string Vencfac { get; set; } = null!;
        public string Refefac { get; set; } = null!;
        public string Iditem { get; set; } = null!;
        public decimal Sdancta { get; set; }
        public decimal Mvdbcta { get; set; }
        public decimal Mvcrcta { get; set; }
        public decimal Sdaccta { get; set; }
        public decimal Sdanmcta { get; set; }
        public decimal Mvdbmcta { get; set; }
        public decimal Mvcrmcta { get; set; }
        public decimal Sdacmcta { get; set; }
        public decimal IdenLibro { get; set; }
        public string Idbanco { get; set; } = null!;
        public string Propiedad1 { get; set; } = null!;
        public string Propiedad2 { get; set; } = null!;
        public string Propiedad3 { get; set; } = null!;
        public string Propiedad4 { get; set; } = null!;
        public string Propiedad5 { get; set; } = null!;
        public decimal SdanctaT { get; set; }
        public decimal SdacctaT { get; set; }
        public decimal SdanmctaT { get; set; }
        public decimal SdacmctaT { get; set; }
        public int IdenSaldogeneral { get; set; }
    }
}
