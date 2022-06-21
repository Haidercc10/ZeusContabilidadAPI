using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class PlantillaDocactual
    {
        public decimal Idplantilla { get; set; }
        public string Plantilla { get; set; } = null!;
        public string Anodcto { get; set; } = null!;
        public string Fntedcto { get; set; } = null!;
        public string Numedcto { get; set; } = null!;
        public string Fechdcto { get; set; } = null!;
        public short? Numtdcto { get; set; }
        public decimal? Sudbdcto { get; set; }
        public decimal? Sucrdcto { get; set; }
        public string? Iactdcto { get; set; }
        public string? Descdcto { get; set; }
        public string? Idcenco { get; set; }
        public string? Idtercero { get; set; }
        public string? Idcliprv { get; set; }
        public string? Idbanco { get; set; }
        public string? Cbadcto { get; set; }
        public string? Chedcto { get; set; }
        public decimal? Vchdcto { get; set; }
        public string? Entregado { get; set; }
        public string? Tprecdcto { get; set; }
        public string? Ndrecdcto { get; set; }
        public DateTime? Enfdcto { get; set; }
        public string? Auxiliar { get; set; }
        public string? Item { get; set; }
        public string? Statusdcto { get; set; }
        public string? Benefdcto { get; set; }
        public string? Impricheque { get; set; }
        public string? Montoletras { get; set; }
        public string Moneda { get; set; } = null!;
        public decimal VrMoneda { get; set; }
        public string MontoMoneda { get; set; } = null!;
        public string VencCheque { get; set; } = null!;
        public decimal TasaCambio { get; set; }
        public string Bu { get; set; } = null!;
        public string? Ncf { get; set; }
        public string? NcfModificado { get; set; }
        public int IdenPlantillaDocactual { get; set; }

        public virtual Bu BuNavigation { get; set; } = null!;
    }
}
