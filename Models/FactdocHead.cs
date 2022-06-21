using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class FactdocHead
    {
        public string TipodctoFhe { get; set; } = null!;
        public string FuenteFhe { get; set; } = null!;
        public string DocumentoFhe { get; set; } = null!;
        public string FechaFhe { get; set; } = null!;
        public string? ClienteFhe { get; set; }
        public string? ProveedorFhe { get; set; }
        public int FormapagoFhe { get; set; }
        public string TipofactFhe { get; set; } = null!;
        public int? DiasvenFhe { get; set; }
        public string? CtacajaFhe { get; set; }
        public string? CuentaFhe { get; set; }
        public string? ReferenciaFhe { get; set; }
        public decimal VrconceFhe { get; set; }
        public decimal VrdsctoFhe { get; set; }
        public decimal VrivaFhe { get; set; }
        public decimal? VranticipoFhe { get; set; }
        public string? ObservFhe { get; set; }
        public string StatusFhe { get; set; } = null!;
        public string? VendedorFhe { get; set; }
        public string? MonedaFhe { get; set; }
        public decimal? TcambioFhe { get; set; }
        public string? MontoFhe { get; set; }
        public decimal? FactorFhe { get; set; }
        public string? ConceptoFhe { get; set; }
        public string NumefacFhe { get; set; } = null!;
        public string FechafactFhe { get; set; } = null!;
        public string SerieFhe { get; set; } = null!;
        public string? AutorizacionFhe { get; set; }
        public string? UsuarioFhe { get; set; }
        public string? AprobadoporFhe { get; set; }
        public string? CentrocostoFhe { get; set; }
        public int? PlantillaFhe { get; set; }
        public string? NcfFhe { get; set; }
        public string? NcfModificadoFhe { get; set; }
        public string? FuenteRegPresuFhe { get; set; }
        public string? DocumRegPresupFhe { get; set; }
        public string? FuenteRelacionadoPresuFhe { get; set; }
        public string? DocumRelacionadoPresupFhe { get; set; }
        public string? FechaCaducidadFhe { get; set; }
        public string? OrdenCompraPresupFhe { get; set; }
        public string? ComprobanteImpuestoFhe { get; set; }
        public int? IdenAutorizacionCiFhe { get; set; }
        public string Bu { get; set; } = null!;
        public string? ItemFhe { get; set; }
        public string? CodigoPropiedad1Fhe { get; set; }
        public string? CodigoPropiedad2Fhe { get; set; }
        public string? CodigoPropiedad3Fhe { get; set; }
        public string? CodigoPropiedad4Fhe { get; set; }
        public string? CodigoPropiedad5Fhe { get; set; }
        public decimal? ConsecutivoControlDocumentario { get; set; }
        public string CicloFhe { get; set; } = null!;
        public string IdmodeloFhe { get; set; } = null!;
        public string IddocumFhe { get; set; } = null!;
        public decimal NovedadFhe { get; set; }
        public int IdenFactdocHead { get; set; }
        public byte[] VersionDeLaFila { get; set; } = null!;
        public string? BienRete { get; set; }

        public virtual Bu BuNavigation { get; set; } = null!;
        public virtual ControlDocumentarioRecepcionDocumento? ConsecutivoControlDocumentarioNavigation { get; set; }
        public virtual Fuente FuenteFheNavigation { get; set; } = null!;
    }
}
