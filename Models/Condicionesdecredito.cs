using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class Condicionesdecredito
    {
        public Condicionesdecredito()
        {
            TablaAmortizacionParametros = new HashSet<TablaAmortizacionParametro>();
        }

        public decimal Iden { get; set; }
        public string Codigo { get; set; } = null!;
        public string Nombre { get; set; } = null!;
        public string Detalle { get; set; } = null!;
        public short TipoCondicion { get; set; }
        public bool Deshabilitada { get; set; }
        public short TipoInteresPactado { get; set; }
        public short TipoTasaInteres { get; set; }
        public short TipoPeriodicidad { get; set; }
        public short TipoCobroInteres { get; set; }
        public bool ModificarTasaInteres { get; set; }
        public double TasaInteresMin { get; set; }
        public double TasaInteresMax { get; set; }
        public string? Ctaingreso { get; set; }
        public string? Centrocosto { get; set; }
        public string? Auxiliar { get; set; }
        public string? Propiedad1 { get; set; }
        public string? Propiedad2 { get; set; }
        public string? Propiedad3 { get; set; }
        public string? Propiedad4 { get; set; }
        public string? Propiedad5 { get; set; }
        public string? Item { get; set; }
        public string? CtaingresoGanancia { get; set; }
        public string? CentrocostoGanancia { get; set; }
        public string? AuxiliarGanancia { get; set; }
        public string? Propiedad1Ganancia { get; set; }
        public string? Propiedad2Ganancia { get; set; }
        public string? Propiedad3Ganancia { get; set; }
        public string? Propiedad4Ganancia { get; set; }
        public string? Propiedad5Ganancia { get; set; }
        public string? ItemGanancia { get; set; }
        public string? CtaingresoPerdida { get; set; }
        public string? CentrocostoPerdida { get; set; }
        public string? AuxiliarPerdida { get; set; }
        public string? Propiedad1Perdida { get; set; }
        public string? Propiedad2Perdida { get; set; }
        public string? Propiedad3Perdida { get; set; }
        public string? Propiedad4Perdida { get; set; }
        public string? Propiedad5Perdida { get; set; }
        public string? ItemPerdida { get; set; }
        public bool ModificarTasaInteresComparativa { get; set; }
        public int ManejaTinteresVariable { get; set; }
        public int? IdenTasasInteres { get; set; }
        public string? CtaDiferencia { get; set; }
        public int? TipoBaseCalculo { get; set; }
        public int? TipoTasaLocal { get; set; }
        public int? TipoSpreadLocal { get; set; }
        public int? TipoTasa { get; set; }
        public bool Amortizable { get; set; }
        public int TipoAmortizacion { get; set; }
        public int TasaPeriodo { get; set; }
        public int? ConfAuxiliar { get; set; }

        public virtual ICollection<TablaAmortizacionParametro> TablaAmortizacionParametros { get; set; }
    }
}
