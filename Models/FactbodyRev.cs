using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class FactbodyRev
    {
        public string ConceFbo { get; set; } = null!;
        public string FuenteFbo { get; set; } = null!;
        public string DocumFbo { get; set; } = null!;
        public string? CcostoFbo { get; set; }
        public string? AuxiliarFbo { get; set; }
        public string DbcrFbo { get; set; } = null!;
        public decimal? CantiFbo { get; set; }
        public decimal VruniFbo { get; set; }
        public decimal VrtotFbo { get; set; }
        public decimal? PordesFbo { get; set; }
        public decimal PorivaFbo { get; set; }
        public decimal? PorretFbo { get; set; }
        public decimal? BaseivaFbo { get; set; }
        public decimal? BaseretFbo { get; set; }
        public string? MonedaFbo { get; set; }
        public int ConsecuFbo { get; set; }
        public string? DeslargaFbo { get; set; }
        public string? CliprvFbo { get; set; }
        public string? TdFbo { get; set; }
        public string? DctoFbo { get; set; }
        public string? VctoFbo { get; set; }
        public string? RefeFbo { get; set; }
        public decimal? VrunimonedaFbo { get; set; }
        public decimal? SubtotalFbo { get; set; }
        public decimal? VrtotdesFbo { get; set; }
        public decimal? VrtotivaFbo { get; set; }
        public string? Unidad1Fbo { get; set; }
        public decimal? Vrunidad1Fbo { get; set; }
        public string? Unidad2Fbo { get; set; }
        public decimal? Vrunidad2Fbo { get; set; }
        public string? Unidad3Fbo { get; set; }
        public decimal? Vrunidad3Fbo { get; set; }
        public string? ItemFbo { get; set; }
        public decimal ValorAjuste { get; set; }
        public string CuentaAjuste { get; set; } = null!;
        public string Zona { get; set; } = null!;
        public string Vendedor { get; set; } = null!;
        public int ConceptoAutomatico { get; set; }
        public string Tercero { get; set; } = null!;
        public string ConceRelacionado { get; set; } = null!;
        public string Bu { get; set; } = null!;
        public string? CodigoPropiedad1Fbo { get; set; }
        public string? CodigoPropiedad2Fbo { get; set; }
        public string? CodigoPropiedad3Fbo { get; set; }
        public string? CodigoPropiedad4Fbo { get; set; }
        public string? CodigoPropiedad5Fbo { get; set; }
        public decimal Novedad { get; set; }
        public string? CodpresuFbo { get; set; }
        public string? ReservapresuFbo { get; set; }
        public int IdenFactbodyRev { get; set; }
        public string? Mandato { get; set; }
        public string? CodigoCxC { get; set; }
        public string? CambioIva { get; set; }
        public decimal? VlrIvaOrig { get; set; }
        public decimal VlrBaseivaOrig { get; set; }

        public virtual Bu BuNavigation { get; set; } = null!;
        public virtual Factconc ConceFboNavigation { get; set; } = null!;
        public virtual FactheadRev FactheadRev { get; set; } = null!;
        public virtual Fuente FuenteFboNavigation { get; set; } = null!;
    }
}
