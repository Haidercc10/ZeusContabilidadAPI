using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class Proveedore
    {
        public Proveedore()
        {
            CfactAutoConceptos = new HashSet<CfactAutoConcepto>();
            GerBancoItauColombiaProvs = new HashSet<GerBancoItauColombiaProv>();
            MpgDocumentos = new HashSet<MpgDocumento>();
            PagosAcarteras = new HashSet<PagosAcartera>();
            ProveedoresAnticipos = new HashSet<ProveedoresAnticipo>();
            SaldoprovBus = new HashSet<SaldoprovBu>();
        }

        public string Idprove { get; set; } = null!;
        public string Idtercero { get; set; } = null!;
        public string Razoncial { get; set; } = null!;
        public string? Direccion { get; set; }
        public string? Ciudad { get; set; }
        public string? Telefono { get; set; }
        public string? Fax { get; set; }
        public string? Email { get; set; }
        public string? Website { get; set; }
        public string? Idzona { get; set; }
        public short? Diplazo { get; set; }
        public decimal? Cupocre { get; set; }
        public string Codicta { get; set; } = null!;
        public string? Contacto { get; set; }
        public string? Dirconta { get; set; }
        public string? Emailconta { get; set; }
        public string? Telconta { get; set; }
        public string? Contactoa { get; set; }
        public string? Dircontaa { get; set; }
        public string? Emailcontaa { get; set; }
        public string? Telcontaa { get; set; }
        public string? Gerente { get; set; }
        public string? Dirgerente { get; set; }
        public string? Emailgeren { get; set; }
        public string? Telgerente { get; set; }
        public string? Dircorres { get; set; }
        public string? Segmento { get; set; }
        public string? Codigoubicacion { get; set; }
        public string? Divpolitica { get; set; }
        public string? Codigodane { get; set; }
        public string? Serie { get; set; }
        public string? Autorizacion { get; set; }
        public string Codalterno { get; set; } = null!;
        public byte Indemail { get; set; }
        public string Tag { get; set; } = null!;
        public string? PrefijoNcf { get; set; }
        public string? GrEmpresarial { get; set; }
        public string? CentroCosto { get; set; }
        public string? Pais { get; set; }
        public string Tipo { get; set; } = null!;
        public string? Item { get; set; }
        public byte? Bloqueo { get; set; }
        public byte? BloqAutorizacion { get; set; }
        public int Deshabilitado { get; set; }
        public int? IdClaseProv { get; set; }
        public byte[] VersionDeLaFila { get; set; } = null!;
        public int IdenProveedores { get; set; }

        public virtual Maecco? CentroCostoNavigation { get; set; }
        public virtual Maecont CodictaNavigation { get; set; } = null!;
        public virtual Ubicaciongeografica? CodigoubicacionNavigation { get; set; }
        public virtual Divpolitica? DivpoliticaNavigation { get; set; }
        public virtual GrEmpresarial? GrEmpresarialNavigation { get; set; }
        public virtual MaeClasesProv? IdClaseProvNavigation { get; set; }
        public virtual Tercero IdterceroNavigation { get; set; } = null!;
        public virtual Maezona? IdzonaNavigation { get; set; }
        public virtual Item? ItemNavigation { get; set; }
        public virtual Paise? PaisNavigation { get; set; }
        public virtual Segmento? SegmentoNavigation { get; set; }
        public virtual ICollection<CfactAutoConcepto> CfactAutoConceptos { get; set; }
        public virtual ICollection<GerBancoItauColombiaProv> GerBancoItauColombiaProvs { get; set; }
        public virtual ICollection<MpgDocumento> MpgDocumentos { get; set; }
        public virtual ICollection<PagosAcartera> PagosAcarteras { get; set; }
        public virtual ICollection<ProveedoresAnticipo> ProveedoresAnticipos { get; set; }
        public virtual ICollection<SaldoprovBu> SaldoprovBus { get; set; }
    }
}
