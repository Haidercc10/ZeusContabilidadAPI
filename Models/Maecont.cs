using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class Maecont
    {
        public Maecont()
        {
            Auxiliars = new HashSet<Auxiliar>();
            Bus = new HashSet<Bu>();
            Clientes = new HashSet<Cliente>();
            ClientesAnticipos = new HashSet<ClientesAnticipo>();
            ClientesCxCmoras = new HashSet<ClientesCxCmora>();
            ContPppMetodoPagos = new HashSet<ContPppMetodoPago>();
            DctocajaBus = new HashSet<DctocajaBu>();
            Difepars = new HashSet<Difepar>();
            FactNotaCausacionCuentaIvaNavigations = new HashSet<FactNotaCausacion>();
            FactNotaCausacionCuentaOrdenNavigations = new HashSet<FactNotaCausacion>();
            Factconcs = new HashSet<Factconc>();
            FacturasBus = new HashSet<FacturasBu>();
            FacturasVsCobroLogs = new HashSet<FacturasVsCobroLog>();
            FacturasVsCobros = new HashSet<FacturasVsCobro>();
            ImpExtractosCodMovimientos = new HashSet<ImpExtractosCodMovimiento>();
            ImpExtractosDefinicions = new HashSet<ImpExtractosDefinicion>();
            ImpuestosBus = new HashSet<ImpuestosBu>();
            MaeccoCuenta = new HashSet<MaeccoCuenta>();
            MonedaCtacomi0Navigations = new HashSet<Moneda>();
            MonedaCtacomi1Navigations = new HashSet<Moneda>();
            MonedaCtacomi2Navigations = new HashSet<Moneda>();
            MonedaCtacomi3Navigations = new HashSet<Moneda>();
            MonedaCtacomi4Navigations = new HashSet<Moneda>();
            MonedaCtacomiNavigations = new HashSet<Moneda>();
            MpgRubroCuentaCapropiacionNavigations = new HashSet<MpgRubro>();
            MpgRubroCuentaCcierreNavigations = new HashSet<MpgRubro>();
            MpgRubroCuentaCcxPNavigations = new HashSet<MpgRubro>();
            MpgRubroCuentaCdpNavigations = new HashSet<MpgRubro>();
            MpgRubroCuentaCierreCxPNavigations = new HashSet<MpgRubro>();
            MpgRubroCuentaCierrePNavigations = new HashSet<MpgRubro>();
            MpgRubroCuentaCierreReservaNavigations = new HashSet<MpgRubro>();
            MpgRubroCuentaCreservaNavigations = new HashSet<MpgRubro>();
            MpgRubroCuentaObligacionNavigations = new HashSet<MpgRubro>();
            MpgRubroCuentaOreservaNavigations = new HashSet<MpgRubro>();
            MpgRubroCuentaPapropiacionNavigations = new HashSet<MpgRubro>();
            MpgRubroCuentaPcierreNavigations = new HashSet<MpgRubro>();
            MpgRubroCuentaPcxPNavigations = new HashSet<MpgRubro>();
            MpgRubroCuentaPreservaNavigations = new HashSet<MpgRubro>();
            MpgRubroCuentaRegistroNavigations = new HashSet<MpgRubro>();
            Pago3rosBus = new HashSet<Pago3rosBu>();
            PagosAcarteras = new HashSet<PagosAcartera>();
            Proveedores = new HashSet<Proveedore>();
            ProveedoresAnticipos = new HashSet<ProveedoresAnticipo>();
            RelacionCtasImpuestoCuentaBaseNavigations = new HashSet<RelacionCtasImpuesto>();
            RelacionCtasImpuestoCuentaPrincipalNavigations = new HashSet<RelacionCtasImpuesto>();
            RolesCuentaAuxiliars = new HashSet<RolesCuentaAuxiliar>();
            SaldoPropiedad1s = new HashSet<SaldoPropiedad1>();
            SaldoPropiedad2s = new HashSet<SaldoPropiedad2>();
            SaldoPropiedad3s = new HashSet<SaldoPropiedad3>();
            SaldoPropiedad4s = new HashSet<SaldoPropiedad4>();
            SaldoPropiedad5s = new HashSet<SaldoPropiedad5>();
            SaldoauxBus = new HashSet<SaldoauxBu>();
            SaldoccoBus = new HashSet<SaldoccoBu>();
            SaldoclieBus = new HashSet<SaldoclieBu>();
            SaldocontBus = new HashSet<SaldocontBu>();
            SaldoitemsBus = new HashSet<SaldoitemsBu>();
            SaldoprovBus = new HashSet<SaldoprovBu>();
            Transacs = new HashSet<Transac>();
            ValeCuentaAnticipoNavigations = new HashSet<Vale>();
            ValeCuentaIngresoNavigations = new HashSet<Vale>();
        }

        public string Codicta { get; set; } = null!;
        public string Desccta { get; set; } = null!;
        public byte Nivelcta { get; set; }
        public string Tipocta { get; set; } = null!;
        public string Coddcta { get; set; } = null!;
        public byte Catfcta { get; set; }
        public DateTime Feapcta { get; set; }
        public byte Indpg3cta { get; set; }
        public byte? Indcpicta { get; set; }
        public string? Idbanco { get; set; }
        public byte? Indccocta { get; set; }
        public string? Cierrecta { get; set; }
        public string? Ajuinfcta { get; set; }
        public string? Coninfcta { get; set; }
        public int? Ncdpgcta { get; set; }
        public string? Uniadic1 { get; set; }
        public string? Codiaju1 { get; set; }
        public string? Uniadic2 { get; set; }
        public string? Codiaju2 { get; set; }
        public string? Uniadic3 { get; set; }
        public string? Codiaju3 { get; set; }
        public byte? Induncal { get; set; }
        public string? Formucal { get; set; }
        public string? Controlpresu { get; set; }
        public string? Distribucion { get; set; }
        public string? Idmoneda { get; set; }
        public string? Codiajuste { get; set; }
        public decimal? Porceimpuesto { get; set; }
        public string? Datosimpuestos { get; set; }
        public string? Ctacorriente { get; set; }
        public string? Identicta { get; set; }
        public byte? Cierre3rocta { get; set; }
        public byte Habilitarcta { get; set; }
        public string? Naturalezacta { get; set; }
        public string? Grupo { get; set; }
        public string TasaAjuste { get; set; } = null!;
        public byte IndBaseP0 { get; set; }
        public byte? IndNcf { get; set; }
        public byte? Nivelparamayor { get; set; }
        public string? CtaAjusteMonPerdida { get; set; }
        public byte ExigeItem { get; set; }
        public string? Categoria { get; set; }
        public int ModuloExterno { get; set; }
        public int ValidaSaldo { get; set; }
        public int ValidaSaldo3ro { get; set; }
        public int GeneraDiferido { get; set; }
        public int CtaDePagosAterceros { get; set; }
        public byte IndValorRetenido { get; set; }
        public string? Seccion { get; set; }
        public bool? Indpropiedad1 { get; set; }
        public bool? Indpropiedad2 { get; set; }
        public bool? Indpropiedad3 { get; set; }
        public bool? Indpropiedad4 { get; set; }
        public bool? Indpropiedad5 { get; set; }
        public bool? NoManejaAjusteAutomatico { get; set; }
        public string? CuentaInteresesCorrientes { get; set; }
        public string? CuentaDeterioro { get; set; }
        public string? CodigoTipoImpuestos { get; set; }
        public string? CuentaPpptransitoria { get; set; }
        public string? RubroEf { get; set; }
        public string? TipoCtaBancaria { get; set; }
        public byte[] VersionDeLaFila { get; set; } = null!;
        public int IdenMaecont { get; set; }
        public string? CtaAjusteMonGananciaPagado { get; set; }
        public string? CtaAjusteMonPerdidaPagado { get; set; }

        public virtual MaeCategoria? CategoriaNavigation { get; set; }
        public virtual Maegrupo? GrupoNavigation { get; set; }
        public virtual Banco? IdbancoNavigation { get; set; }
        public virtual Moneda? IdmonedaNavigation { get; set; }
        public virtual Maeunid? Uniadic1Navigation { get; set; }
        public virtual Maeunid? Uniadic2Navigation { get; set; }
        public virtual Maeunid? Uniadic3Navigation { get; set; }
        public virtual CruceCxCsaldoFavor CruceCxCsaldoFavor { get; set; } = null!;
        public virtual MfCxC MfCxC { get; set; } = null!;
        public virtual ICollection<Auxiliar> Auxiliars { get; set; }
        public virtual ICollection<Bu> Bus { get; set; }
        public virtual ICollection<Cliente> Clientes { get; set; }
        public virtual ICollection<ClientesAnticipo> ClientesAnticipos { get; set; }
        public virtual ICollection<ClientesCxCmora> ClientesCxCmoras { get; set; }
        public virtual ICollection<ContPppMetodoPago> ContPppMetodoPagos { get; set; }
        public virtual ICollection<DctocajaBu> DctocajaBus { get; set; }
        public virtual ICollection<Difepar> Difepars { get; set; }
        public virtual ICollection<FactNotaCausacion> FactNotaCausacionCuentaIvaNavigations { get; set; }
        public virtual ICollection<FactNotaCausacion> FactNotaCausacionCuentaOrdenNavigations { get; set; }
        public virtual ICollection<Factconc> Factconcs { get; set; }
        public virtual ICollection<FacturasBu> FacturasBus { get; set; }
        public virtual ICollection<FacturasVsCobroLog> FacturasVsCobroLogs { get; set; }
        public virtual ICollection<FacturasVsCobro> FacturasVsCobros { get; set; }
        public virtual ICollection<ImpExtractosCodMovimiento> ImpExtractosCodMovimientos { get; set; }
        public virtual ICollection<ImpExtractosDefinicion> ImpExtractosDefinicions { get; set; }
        public virtual ICollection<ImpuestosBu> ImpuestosBus { get; set; }
        public virtual ICollection<MaeccoCuenta> MaeccoCuenta { get; set; }
        public virtual ICollection<Moneda> MonedaCtacomi0Navigations { get; set; }
        public virtual ICollection<Moneda> MonedaCtacomi1Navigations { get; set; }
        public virtual ICollection<Moneda> MonedaCtacomi2Navigations { get; set; }
        public virtual ICollection<Moneda> MonedaCtacomi3Navigations { get; set; }
        public virtual ICollection<Moneda> MonedaCtacomi4Navigations { get; set; }
        public virtual ICollection<Moneda> MonedaCtacomiNavigations { get; set; }
        public virtual ICollection<MpgRubro> MpgRubroCuentaCapropiacionNavigations { get; set; }
        public virtual ICollection<MpgRubro> MpgRubroCuentaCcierreNavigations { get; set; }
        public virtual ICollection<MpgRubro> MpgRubroCuentaCcxPNavigations { get; set; }
        public virtual ICollection<MpgRubro> MpgRubroCuentaCdpNavigations { get; set; }
        public virtual ICollection<MpgRubro> MpgRubroCuentaCierreCxPNavigations { get; set; }
        public virtual ICollection<MpgRubro> MpgRubroCuentaCierrePNavigations { get; set; }
        public virtual ICollection<MpgRubro> MpgRubroCuentaCierreReservaNavigations { get; set; }
        public virtual ICollection<MpgRubro> MpgRubroCuentaCreservaNavigations { get; set; }
        public virtual ICollection<MpgRubro> MpgRubroCuentaObligacionNavigations { get; set; }
        public virtual ICollection<MpgRubro> MpgRubroCuentaOreservaNavigations { get; set; }
        public virtual ICollection<MpgRubro> MpgRubroCuentaPapropiacionNavigations { get; set; }
        public virtual ICollection<MpgRubro> MpgRubroCuentaPcierreNavigations { get; set; }
        public virtual ICollection<MpgRubro> MpgRubroCuentaPcxPNavigations { get; set; }
        public virtual ICollection<MpgRubro> MpgRubroCuentaPreservaNavigations { get; set; }
        public virtual ICollection<MpgRubro> MpgRubroCuentaRegistroNavigations { get; set; }
        public virtual ICollection<Pago3rosBu> Pago3rosBus { get; set; }
        public virtual ICollection<PagosAcartera> PagosAcarteras { get; set; }
        public virtual ICollection<Proveedore> Proveedores { get; set; }
        public virtual ICollection<ProveedoresAnticipo> ProveedoresAnticipos { get; set; }
        public virtual ICollection<RelacionCtasImpuesto> RelacionCtasImpuestoCuentaBaseNavigations { get; set; }
        public virtual ICollection<RelacionCtasImpuesto> RelacionCtasImpuestoCuentaPrincipalNavigations { get; set; }
        public virtual ICollection<RolesCuentaAuxiliar> RolesCuentaAuxiliars { get; set; }
        public virtual ICollection<SaldoPropiedad1> SaldoPropiedad1s { get; set; }
        public virtual ICollection<SaldoPropiedad2> SaldoPropiedad2s { get; set; }
        public virtual ICollection<SaldoPropiedad3> SaldoPropiedad3s { get; set; }
        public virtual ICollection<SaldoPropiedad4> SaldoPropiedad4s { get; set; }
        public virtual ICollection<SaldoPropiedad5> SaldoPropiedad5s { get; set; }
        public virtual ICollection<SaldoauxBu> SaldoauxBus { get; set; }
        public virtual ICollection<SaldoccoBu> SaldoccoBus { get; set; }
        public virtual ICollection<SaldoclieBu> SaldoclieBus { get; set; }
        public virtual ICollection<SaldocontBu> SaldocontBus { get; set; }
        public virtual ICollection<SaldoitemsBu> SaldoitemsBus { get; set; }
        public virtual ICollection<SaldoprovBu> SaldoprovBus { get; set; }
        public virtual ICollection<Transac> Transacs { get; set; }
        public virtual ICollection<Vale> ValeCuentaAnticipoNavigations { get; set; }
        public virtual ICollection<Vale> ValeCuentaIngresoNavigations { get; set; }
    }
}
