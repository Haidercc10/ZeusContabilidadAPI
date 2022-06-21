using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class Document
    {
        public Document()
        {
            ArchivoFisicoDocumentos = new HashSet<ArchivoFisicoDocumento>();
            FactNotaCausacions = new HashSet<FactNotaCausacion>();
            FactRelacionCausacionDocumentNavigations = new HashSet<FactRelacionCausacion>();
            FactRelacionCausacionDocuments = new HashSet<FactRelacionCausacion>();
            MfPagarePrestamoHeads = new HashSet<MfPagarePrestamoHead>();
            PagosAcarteras = new HashSet<PagosAcartera>();
            Valeras = new HashSet<Valera>();
        }

        public string Anodcto { get; set; } = null!;
        public string Fntedcto { get; set; } = null!;
        public string Numedcto { get; set; } = null!;
        public string Fechdcto { get; set; } = null!;
        public int? Numtdcto { get; set; }
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
        public decimal? Nreversiones { get; set; }
        public string? AjusteInflacion { get; set; }
        public decimal? PaagMes { get; set; }
        public decimal? PaagAcu { get; set; }
        public string? IndContabPrestamo { get; set; }
        public decimal NumVales { get; set; }
        public decimal NumValesConciliados { get; set; }
        public string? Ncf { get; set; }
        public string? NcfModificado { get; set; }
        public string Moneda { get; set; } = null!;
        public decimal VrMoneda { get; set; }
        public string MontoMoneda { get; set; } = null!;
        public string VencCheque { get; set; } = null!;
        public decimal TasaCambio { get; set; }
        public string Bu { get; set; } = null!;
        public string GenEsquema { get; set; } = null!;
        public string? Cierre { get; set; }
        public string? XmlAdicionales { get; set; }
        public int? IdAplicacionesZeus { get; set; }
        public string? AgruparNit { get; set; }
        public decimal? IdenDatosImpuestos { get; set; }
        public string? IdDocumentoExterno { get; set; }
        public int IdenDocument { get; set; }
        public byte[] VersionDeLaFila { get; set; } = null!;
        public string? AreaEmpresa { get; set; }
        public DateTime? FechaEntregaAreaEmpresa { get; set; }
        public bool? ChequeEntregado { get; set; }
        public string? CodTipoIdentificacion { get; set; }
        public bool BlGenChequesPosfechados { get; set; }
        public DateTime? FechaPreContabilizacion { get; set; }
        public string AutorizoPreContab { get; set; } = null!;
        public string EstadoPreContab { get; set; } = null!;
        public bool BlRevisado { get; set; }
        public DateTime? FechaRevision { get; set; }
        public string AutorizoRevision { get; set; } = null!;

        public virtual Area? AreaEmpresaNavigation { get; set; }
        public virtual Bu BuNavigation { get; set; } = null!;
        public virtual ICollection<ArchivoFisicoDocumento> ArchivoFisicoDocumentos { get; set; }
        public virtual ICollection<FactNotaCausacion> FactNotaCausacions { get; set; }
        public virtual ICollection<FactRelacionCausacion> FactRelacionCausacionDocumentNavigations { get; set; }
        public virtual ICollection<FactRelacionCausacion> FactRelacionCausacionDocuments { get; set; }
        public virtual ICollection<MfPagarePrestamoHead> MfPagarePrestamoHeads { get; set; }
        public virtual ICollection<PagosAcartera> PagosAcarteras { get; set; }
        public virtual ICollection<Valera> Valeras { get; set; }
    }
}
