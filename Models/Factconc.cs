using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class Factconc
    {
        public Factconc()
        {
            CfactAutoConceptos = new HashSet<CfactAutoConcepto>();
            CfactModeloBs = new HashSet<CfactModeloB>();
            ConceptosAutomaticos = new HashSet<ConceptosAutomatico>();
            FactConceptosRelacionadoConceptoHijoNavigations = new HashSet<FactConceptosRelacionado>();
            FactConceptosRelacionadoConceptoPadreNavigations = new HashSet<FactConceptosRelacionado>();
            FactNotaCausacions = new HashSet<FactNotaCausacion>();
            FactRelacionCausacions = new HashSet<FactRelacionCausacion>();
            Factbodies = new HashSet<Factbody>();
            FactbodyRevs = new HashSet<FactbodyRev>();
            FactconcUbicaciones = new HashSet<FactconcUbicacione>();
            FactdocBodies = new HashSet<FactdocBody>();
            Factmodelobs = new HashSet<Factmodelob>();
            FacturacionAutoConceptos = new HashSet<FacturacionAutoConcepto>();
        }

        public string ConcFco { get; set; } = null!;
        public string DescFco { get; set; } = null!;
        public int TipoFco { get; set; }
        public decimal? VuniFco { get; set; }
        public decimal? VfijFco { get; set; }
        public string? MoneFco { get; set; }
        public string? FormulaFco { get; set; }
        public string? CodiFco { get; set; }
        public string DbcrFco { get; set; } = null!;
        public string DetalleFco { get; set; } = null!;
        public int IndidescFco { get; set; }
        public int IndiivaFco { get; set; }
        public int IndireteFco { get; set; }
        public decimal PorcedescFco { get; set; }
        public decimal PorceivaFco { get; set; }
        public decimal PorcereteFco { get; set; }
        public string? CodigodescFco { get; set; }
        public string? CodigoivaFco { get; set; }
        public string? CodigoreteFco { get; set; }
        public string? AuxiabtoFco { get; set; }
        public string? CencostoFco { get; set; }
        public decimal? CostoFijo { get; set; }
        public decimal? PorcentajeCosto { get; set; }
        public decimal? PorcentajeComision { get; set; }
        public string? CuentaGastoProvision { get; set; }
        public int TipoImpresion { get; set; }
        public string? TipoTotalizador { get; set; }
        public int TipoConcepto { get; set; }
        public int NoUsarCategoriaFiscal { get; set; }
        public int ConfAuxiliar { get; set; }
        public string? FormulaCantidadFco { get; set; }
        public byte IndDocValor { get; set; }
        public string? CtaIngreso { get; set; }
        public string? CencoIngreso { get; set; }
        public string? AuxiliarIngreso { get; set; }
        public string LeyendaValera { get; set; } = null!;
        public int IndConceptoRelacionado { get; set; }
        public string? IdCategoria { get; set; }
        public int ExigeItem { get; set; }
        public int GeneraCr { get; set; }
        public byte NivConcepto { get; set; }
        public string DepConcepto { get; set; } = null!;
        public int? Ncdconcepto { get; set; }
        public string? TipoConce { get; set; }
        public int GeneraAnexo { get; set; }
        public int Deshabilitado { get; set; }
        public string? Item { get; set; }
        public int ComisionesPagoRecaudoCuota { get; set; }
        public string? NotaCuenta { get; set; }
        public string? NotaIva { get; set; }
        public string? CodigoPropiedad1 { get; set; }
        public string? CodigoPropiedad2 { get; set; }
        public string? CodigoPropiedad3 { get; set; }
        public string? CodigoPropiedad4 { get; set; }
        public string? CodigoPropiedad5 { get; set; }
        public int IndCostoAsociado { get; set; }
        public int? UsaFormulacionAvanzada { get; set; }
        public bool ContabilizaDscto { get; set; }
        public string BienServicio { get; set; } = null!;
        public string? ReservaPresupuesto { get; set; }
        public string? RubroPresupuesto { get; set; }
        public int IdenFactconc { get; set; }
        public byte[] VersionDeLaFila { get; set; } = null!;
        public string Mandato { get; set; } = null!;
        public string? CodigoCxC { get; set; }
        public string? CtaGastoProrrateo { get; set; }
        public string? CtaIvaprorrateo { get; set; }
        public string? CtaIngDevolucion { get; set; }
        public string? CtaIvadevolucion { get; set; }
        public string CodigoAlterno { get; set; } = null!;
        public string CambiarIva { get; set; } = null!;

        public virtual Maecco? CencostoFcoNavigation { get; set; }
        public virtual Maecont? CodiFcoNavigation { get; set; }
        public virtual MaeCategoria? IdCategoriaNavigation { get; set; }
        public virtual Moneda? MoneFcoNavigation { get; set; }
        public virtual ICollection<CfactAutoConcepto> CfactAutoConceptos { get; set; }
        public virtual ICollection<CfactModeloB> CfactModeloBs { get; set; }
        public virtual ICollection<ConceptosAutomatico> ConceptosAutomaticos { get; set; }
        public virtual ICollection<FactConceptosRelacionado> FactConceptosRelacionadoConceptoHijoNavigations { get; set; }
        public virtual ICollection<FactConceptosRelacionado> FactConceptosRelacionadoConceptoPadreNavigations { get; set; }
        public virtual ICollection<FactNotaCausacion> FactNotaCausacions { get; set; }
        public virtual ICollection<FactRelacionCausacion> FactRelacionCausacions { get; set; }
        public virtual ICollection<Factbody> Factbodies { get; set; }
        public virtual ICollection<FactbodyRev> FactbodyRevs { get; set; }
        public virtual ICollection<FactconcUbicacione> FactconcUbicaciones { get; set; }
        public virtual ICollection<FactdocBody> FactdocBodies { get; set; }
        public virtual ICollection<Factmodelob> Factmodelobs { get; set; }
        public virtual ICollection<FacturacionAutoConcepto> FacturacionAutoConceptos { get; set; }
    }
}
