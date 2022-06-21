using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class Tercero
    {
        public Tercero()
        {
            Clientes = new HashSet<Cliente>();
            GerBancoItauColombiaProvs = new HashSet<GerBancoItauColombiaProv>();
            ImpExtractosCodMovimientos = new HashSet<ImpExtractosCodMovimiento>();
            MpgDocumentos = new HashSet<MpgDocumento>();
            Pago3rosBus = new HashSet<Pago3rosBu>();
            Proveedores = new HashSet<Proveedore>();
            Reclasificacion3ros = new HashSet<Reclasificacion3ro>();
        }

        public string Idtercero { get; set; } = null!;
        public string Nombreter { get; set; } = null!;
        public string? Digiverif { get; set; }
        public string? Tipoterce { get; set; }
        public string? Segmento { get; set; }
        public string Tipoempresa { get; set; } = null!;
        public string? Direccion { get; set; }
        public string Ciudad { get; set; } = null!;
        public string Divpolitica { get; set; } = null!;
        public string? Codigodane { get; set; }
        public string? Telefono { get; set; }
        public string? TipoIdentificacion { get; set; }
        public string? Nombre1 { get; set; }
        public string? Nombre2 { get; set; }
        public string? Apellido1 { get; set; }
        public string? Apellido2 { get; set; }
        public string? TipoRazonSocial { get; set; }
        public string? PrefijoNcf { get; set; }
        public string? Sexo { get; set; }
        public string? Profesion { get; set; }
        public DateTime? FechaNacimiento { get; set; }
        public string? Hobbies { get; set; }
        public string? NombreConyugue { get; set; }
        public DateTime? FechaNacimientoConyugue { get; set; }
        public string? TipoClienteFrecuenciaCompra { get; set; }
        public string? EstratoSocial { get; set; }
        public string? Barrio { get; set; }
        public string? Telefono2 { get; set; }
        public string? Celular { get; set; }
        public DateTime? Fechagrabacion { get; set; }
        public string? Pais { get; set; }
        public string Tipo { get; set; } = null!;
        public string? CentroCosto { get; set; }
        public string? Item { get; set; }
        public int Deshabilitado { get; set; }
        public string CodigoOcupacion { get; set; } = null!;
        public string? Email { get; set; }
        public int ManejaAcuerdo { get; set; }
        public DateTime? FechaInicialAcuerdo { get; set; }
        public DateTime? FechaFinalAcuerdo { get; set; }
        public decimal? EscenariosClaseContribuyenteIden { get; set; }
        public decimal? EscenariosCategoriaTributariaIvaIden { get; set; }
        public decimal? EscenariosTipoContribuyenteIden { get; set; }
        public decimal? EscenariosEsAutorretenedorIden { get; set; }
        public decimal? EscenariosAplicaIcatIden { get; set; }
        public decimal? EscenariosTipoRetencionIvaIden { get; set; }
        public string? EscenariosCategoriaTributaria { get; set; }
        public bool AreteSunat { get; set; }
        public bool ApercepSunat { get; set; }
        public bool BuenContriSunat { get; set; }
        public byte[] VersionDeLaFila { get; set; } = null!;
        public int IdenTerceros { get; set; }
        public bool? BlCupoCreditoPorCliente { get; set; }
        public bool BlCupoCreditoPorMoneda { get; set; }
        public int DiasGracia { get; set; }
        public decimal ValorCupoCredito { get; set; }
        public bool BlBloqueo { get; set; }

        public virtual Maecco? CentroCostoNavigation { get; set; }
        public virtual Divpolitica DivpoliticaNavigation { get; set; } = null!;
        public virtual Item? ItemNavigation { get; set; }
        public virtual Paise? PaisNavigation { get; set; }
        public virtual Segmento? SegmentoNavigation { get; set; }
        public virtual TipoIdentificacion? TipoIdentificacionNavigation { get; set; }
        public virtual TiposDeEmpresa TipoempresaNavigation { get; set; } = null!;
        public virtual Ger14general Ger14general { get; set; } = null!;
        public virtual Ger19general Ger19general { get; set; } = null!;
        public virtual GerBancoAvVilla GerBancoAvVilla { get; set; } = null!;
        public virtual GerBcoSudamerisGeneral GerBcoSudamerisGeneral { get; set; } = null!;
        public virtual GerBogotum GerBogotum { get; set; } = null!;
        public virtual GerDaviviendum GerDaviviendum { get; set; } = null!;
        public virtual ICollection<Cliente> Clientes { get; set; }
        public virtual ICollection<GerBancoItauColombiaProv> GerBancoItauColombiaProvs { get; set; }
        public virtual ICollection<ImpExtractosCodMovimiento> ImpExtractosCodMovimientos { get; set; }
        public virtual ICollection<MpgDocumento> MpgDocumentos { get; set; }
        public virtual ICollection<Pago3rosBu> Pago3rosBus { get; set; }
        public virtual ICollection<Proveedore> Proveedores { get; set; }
        public virtual ICollection<Reclasificacion3ro> Reclasificacion3ros { get; set; }
    }
}
