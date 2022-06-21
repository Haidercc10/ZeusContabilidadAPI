using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class PrestamosG
    {
        public PrestamosG()
        {
            PrestamosDs = new HashSet<PrestamosD>();
            PrestamosGrupos = new HashSet<PrestamosGrupo>();
        }

        public decimal IdPrestamoG { get; set; }
        public string? CodPrestamo { get; set; }
        public string? CodCliente { get; set; }
        public string? Fecha { get; set; }
        public string? CodAsesor { get; set; }
        public decimal? ValorPrestamo { get; set; }
        public decimal? PorcInteres { get; set; }
        public int? Plazo { get; set; }
        public decimal? VrEstudio { get; set; }
        public string? TdEstudio { get; set; }
        public decimal? VrSeguros { get; set; }
        public string? TdSeguros { get; set; }
        public decimal? VrCapacitacion { get; set; }
        public string? TdCapacitacion { get; set; }
        public decimal? VrComision { get; set; }
        public string? TdComision { get; set; }
        public decimal? ValorCuota { get; set; }
        public decimal? TotalCapital { get; set; }
        public decimal? TotalInteres { get; set; }
        public string? FechaIniVenc { get; set; }
        public string? FechaFinVenc { get; set; }
        public string? FuenteContab { get; set; }
        public string? DocumContab { get; set; }
        public string? Status { get; set; }
        public bool? TipoPrestamo { get; set; }
        public string? CodigoGrupo { get; set; }
        public string? CodigoPoliza { get; set; }
        public string? CxC { get; set; }
        public string? IndCliBen { get; set; }
        public string? CtaCapacitacion { get; set; }
        public string? CtaComision { get; set; }
        public string? CtaEstudio { get; set; }
        public string? CtaIngreso { get; set; }
        public string? CtaSeguro { get; set; }
        public int? CodEstudio { get; set; }
        public string TipoEstudio { get; set; } = null!;
        public string TipoFactura { get; set; } = null!;
        public int IdComite { get; set; }
        public decimal CausacionEstudio { get; set; }
        public decimal CausacionSeguros { get; set; }
        public decimal CausacionCapacitacion { get; set; }
        public decimal CausacionComision { get; set; }
        public int Periodo { get; set; }
        public string DescSeguro { get; set; } = null!;
        public string CtaIngresoMora { get; set; } = null!;
        public string IndModEstudio { get; set; } = null!;
        public string IndModSeguros { get; set; } = null!;
        public string IndModCapacitacion { get; set; } = null!;
        public string IndModComision { get; set; } = null!;
        public string AutSinCodeudor { get; set; } = null!;
        public int PagarePrestamo { get; set; }
        public int Simulacion { get; set; }

        public virtual Maevende? CodAsesorNavigation { get; set; }
        public virtual ICollection<PrestamosD> PrestamosDs { get; set; }
        public virtual ICollection<PrestamosGrupo> PrestamosGrupos { get; set; }
    }
}
