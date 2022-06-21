using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class Fuente
    {
        public Fuente()
        {
            Factbodies = new HashSet<Factbody>();
            FactbodyRevs = new HashSet<FactbodyRev>();
            FactdocBodies = new HashSet<FactdocBody>();
            FactdocCuota = new HashSet<FactdocCuotum>();
            FactdocHeads = new HashSet<FactdocHead>();
            FactdocPagos = new HashSet<FactdocPago>();
            FactheadRevs = new HashSet<FactheadRev>();
            Factheads = new HashSet<Facthead>();
            MfPagarePrestamoHeads = new HashSet<MfPagarePrestamoHead>();
            MpgDocumentos = new HashSet<MpgDocumento>();
            MpgLiberarSaldos = new HashSet<MpgLiberarSaldo>();
            Numcons = new HashSet<Numcon>();
            PagosAcarteras = new HashSet<PagosAcartera>();
            Transacs = new HashSet<Transac>();
            UsuariosPermisoDctos = new HashSet<UsuariosPermisoDcto>();
        }

        public string Idfuente { get; set; } = null!;
        public string Desfuente { get; set; } = null!;
        public string Idtipdoc { get; set; } = null!;
        public string? Rptcontable { get; set; }
        public string? Rptformato { get; set; }
        public string? Estilo { get; set; }
        public string SpCreacionDcto { get; set; } = null!;
        public string SpReutilizacionDcto { get; set; } = null!;
        public string SpReversionDcto { get; set; } = null!;
        public string SpAperturaDcto { get; set; } = null!;
        public string SpCierreDcto { get; set; } = null!;
        public string Autorizacion { get; set; } = null!;
        public string Cierre { get; set; } = null!;
        public int ModuloExterno { get; set; }
        public int Deshabilitado { get; set; }
        public int GeneraDiferido { get; set; }
        public int ManejaFacturaEnLinea { get; set; }
        public int ManejaFacturaDeContingencia { get; set; }
        public int AsociarImpMovCartera { get; set; }
        public int? ControlConsecutivoPorFecha { get; set; }
        public byte[] VersionDeLaFila { get; set; } = null!;
        public int IdenFuentes { get; set; }
        public int? UsarEnNotaDebito { get; set; }
        public bool BlPreContabiliza { get; set; }

        public virtual Tipodcto IdtipdocNavigation { get; set; } = null!;
        public virtual ICollection<Factbody> Factbodies { get; set; }
        public virtual ICollection<FactbodyRev> FactbodyRevs { get; set; }
        public virtual ICollection<FactdocBody> FactdocBodies { get; set; }
        public virtual ICollection<FactdocCuotum> FactdocCuota { get; set; }
        public virtual ICollection<FactdocHead> FactdocHeads { get; set; }
        public virtual ICollection<FactdocPago> FactdocPagos { get; set; }
        public virtual ICollection<FactheadRev> FactheadRevs { get; set; }
        public virtual ICollection<Facthead> Factheads { get; set; }
        public virtual ICollection<MfPagarePrestamoHead> MfPagarePrestamoHeads { get; set; }
        public virtual ICollection<MpgDocumento> MpgDocumentos { get; set; }
        public virtual ICollection<MpgLiberarSaldo> MpgLiberarSaldos { get; set; }
        public virtual ICollection<Numcon> Numcons { get; set; }
        public virtual ICollection<PagosAcartera> PagosAcarteras { get; set; }
        public virtual ICollection<Transac> Transacs { get; set; }
        public virtual ICollection<UsuariosPermisoDcto> UsuariosPermisoDctos { get; set; }
    }
}
