using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class MpgDocumento
    {
        public MpgDocumento()
        {
            InverseIdenRelacionadoNavigation = new HashSet<MpgDocumento>();
            MpgCuota = new HashSet<MpgCuota>();
            MpgDocumentoCesions = new HashSet<MpgDocumentoCesion>();
            MpgItems = new HashSet<MpgItem>();
            MpgLiberarSaldosDets = new HashSet<MpgLiberarSaldosDet>();
            MpgOppdocAsociadoIdenCrpcxpNavigations = new HashSet<MpgOppdocAsociado>();
            MpgOppdocAsociadoIdenOppNavigations = new HashSet<MpgOppdocAsociado>();
            MpgOppentrada = new HashSet<MpgOppentrada>();
        }

        public int Iden { get; set; }
        public int? IdenRelacionado { get; set; }
        public string TipoDocumento { get; set; } = null!;
        public string AnoMes { get; set; } = null!;
        public string Fecha { get; set; } = null!;
        public string? Fuente { get; set; }
        public string? Documento { get; set; }
        public string Estado { get; set; } = null!;
        public DateTime FechaGrabacion { get; set; }
        public string? LugarExpedicion { get; set; }
        public string? Vigencia { get; set; }
        public string? Vencimiento { get; set; }
        public string? Prorroga { get; set; }
        public string? TipoGasto { get; set; }
        public string? DocAutorizacion { get; set; }
        public string? FechaAutorizacion { get; set; }
        public string? Descripcion { get; set; }
        public string? Solicitado { get; set; }
        public decimal? ValorTotal { get; set; }
        public string? Usuario { get; set; }
        public string? FuenteOrden { get; set; }
        public string? DocumentoOrden { get; set; }
        public string? Tercero { get; set; }
        public string? Proveedor { get; set; }
        public string? FuenteEntrada { get; set; }
        public string? DocumentoEntrada { get; set; }
        public string? CxPentrada { get; set; }
        public string? TipoFacturaEntrada { get; set; }
        public string? FacturaEntrada { get; set; }
        public string? ReferenciaEntrada { get; set; }
        public string? ProveedorEntrada { get; set; }
        public string? FuentePago { get; set; }
        public string? DocumentoPago { get; set; }
        public string? TipoCierre { get; set; }
        public int Consecutivo { get; set; }
        public string? TipoDocAutorizacion { get; set; }
        public string? Observaciones { get; set; }
        public string? TipoOpp { get; set; }
        public string? CdpsaldoInicial { get; set; }
        public string? CrpsaldoInicial { get; set; }
        public string? OppsaldoInicial { get; set; }
        public decimal VrRetenciones { get; set; }
        public decimal VrRetencionesDis { get; set; }
        public string Bu { get; set; } = null!;

        public virtual Fuente? FuenteNavigation { get; set; }
        public virtual MpgDocumento? IdenRelacionadoNavigation { get; set; }
        public virtual Proveedore? ProveedorNavigation { get; set; }
        public virtual Tercero? TerceroNavigation { get; set; }
        public virtual MpgTipoDocAutorizacion? TipoDocAutorizacionNavigation { get; set; }
        public virtual Tipodcto TipoDocumentoNavigation { get; set; } = null!;
        public virtual ICollection<MpgDocumento> InverseIdenRelacionadoNavigation { get; set; }
        public virtual ICollection<MpgCuota> MpgCuota { get; set; }
        public virtual ICollection<MpgDocumentoCesion> MpgDocumentoCesions { get; set; }
        public virtual ICollection<MpgItem> MpgItems { get; set; }
        public virtual ICollection<MpgLiberarSaldosDet> MpgLiberarSaldosDets { get; set; }
        public virtual ICollection<MpgOppdocAsociado> MpgOppdocAsociadoIdenCrpcxpNavigations { get; set; }
        public virtual ICollection<MpgOppdocAsociado> MpgOppdocAsociadoIdenOppNavigations { get; set; }
        public virtual ICollection<MpgOppentrada> MpgOppentrada { get; set; }
    }
}
