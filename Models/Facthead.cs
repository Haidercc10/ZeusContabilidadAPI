using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class Facthead
    {
        public Facthead()
        {
            Factbodies = new HashSet<Factbody>();
        }

        public string FuenteFhe { get; set; } = null!;
        public string DocumFhe { get; set; } = null!;
        public string FechaFhe { get; set; } = null!;
        public string ClienteFhe { get; set; } = null!;
        public string TipofacFhe { get; set; } = null!;
        public int? DiasvenFhe { get; set; }
        public string? CtacajaFhe { get; set; }
        public string? CxcFhe { get; set; }
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
        public string? FechatcambioFhe { get; set; }
        public string? CcostoFhe { get; set; }
        public string? AuxiliarFhe { get; set; }
        public string? CtaanticipoFhe { get; set; }
        public string? TfacFhe { get; set; }
        public string? UsuarioFhe { get; set; }
        public string? CicloFhe { get; set; }
        public string? IddocumFhe { get; set; }
        public decimal? NovedadFhe { get; set; }
        public string? IdmodeloFhe { get; set; }
        public string? NcfFhe { get; set; }
        public string? NcfModificadoFhe { get; set; }
        public string? ComprobantefiscalFhe { get; set; }
        public string? Fechafacturacion { get; set; }
        public int? IdenAutorizacionCiFhe { get; set; }
        public string Bu { get; set; } = null!;
        public decimal? FactAutoFhe { get; set; }
        public string? ItemFhe { get; set; }
        public string? CodigoPropiedad1Fhe { get; set; }
        public string? CodigoPropiedad2Fhe { get; set; }
        public string? CodigoPropiedad3Fhe { get; set; }
        public string? CodigoPropiedad4Fhe { get; set; }
        public string? CodigoPropiedad5Fhe { get; set; }
        public string? NumefacFhe { get; set; }
        public string? Prefijo { get; set; }
        public DateTime? FechaRegistroFhe { get; set; }
        public string? HostFhe { get; set; }
        public int IdenFacthead { get; set; }
        public byte[] VersionDeLaFila { get; set; } = null!;
        public decimal? IdenTipoNotaDbcr { get; set; }
        public string NumeroOrdenCompra { get; set; } = null!;

        public virtual Bu BuNavigation { get; set; } = null!;
        public virtual Fuente FuenteFheNavigation { get; set; } = null!;
        public virtual TipoNotaDbcr? IdenTipoNotaDbcrNavigation { get; set; }
        public virtual ICollection<Factbody> Factbodies { get; set; }
    }
}
