using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class TransacTemp
    {
        public string Anotra { get; set; } = null!;
        public string Idfuente { get; set; } = null!;
        public string Numdoctra { get; set; } = null!;
        public int Consecutitra { get; set; }
        public string Fechatra { get; set; } = null!;
        public string Codicta { get; set; } = null!;
        public string Nittra { get; set; } = null!;
        public string? Auxiaux { get; set; }
        public string? Idcenco { get; set; }
        public string? Iditem { get; set; }
        public string Descritra { get; set; } = null!;
        public decimal Valortra { get; set; }
        public string? Indcpitra { get; set; }
        public string? Conciltra { get; set; }
        public string? Idbanco { get; set; }
        public string? Idvende { get; set; }
        public string? Idplaza { get; set; }
        public string? Tipofac { get; set; }
        public string? Numefac { get; set; }
        public string? Vencefac { get; set; }
        public string? Refefac { get; set; }
        public string? Idusuario { get; set; }
        public DateTime Fgratra { get; set; }
        public string? Idzona { get; set; }
        public string? Cliprv { get; set; }
        public decimal? Porretetra { get; set; }
        public decimal? Baseretetra { get; set; }
        public string? Codpresu { get; set; }
        public string? Nreserva { get; set; }
        public decimal? Valormoneda { get; set; }
        public string? Statustra { get; set; }
        public int? Consecurev { get; set; }
        public bool? Indfuente { get; set; }
        public bool? Indperiodo { get; set; }
        public bool? Indcuenta { get; set; }
        public bool? Indcliente { get; set; }
        public bool? Indproveedor { get; set; }
        public bool? Indcencosto { get; set; }
        public bool? Indauxiliar { get; set; }
        public bool? Indtercero { get; set; }
        public bool? Indmoneda { get; set; }
        public bool? Indunidad1 { get; set; }
        public bool? Indunidad2 { get; set; }
        public bool? Indunidad3 { get; set; }
        public bool? Indimpuesto { get; set; }
        public bool? Indvende { get; set; }
        public bool? Indbanco { get; set; }
        public bool? Indplaza { get; set; }
        public bool? Indtipofac { get; set; }
        public string? Aplicacion { get; set; }
        public bool? Procesado { get; set; }
        public string? Idunidad1 { get; set; }
        public string? Idunidad2 { get; set; }
        public string? Idunidad3 { get; set; }
        public decimal? Valorutra1 { get; set; }
        public decimal? Valorutra2 { get; set; }
        public decimal? Valorutra3 { get; set; }
        public string? Serie { get; set; }
        public string? Autorizacion { get; set; }
        public string? Fechafact { get; set; }
        public string? Adicional1 { get; set; }
        public string? Adicional2 { get; set; }
        public string Voucher { get; set; } = null!;
        public decimal TasaCambio { get; set; }
        public string Bu { get; set; } = null!;
        public string? Ncf { get; set; }
        public string? NcfModificado { get; set; }
        public string? FechaCaducidad { get; set; }
        public bool? Indvalor { get; set; }
        public bool? Indvalormoneda { get; set; }
        public bool? Indbaseretetra { get; set; }
        public string? CompReteSerie { get; set; }
        public string? CompReteSecuencial { get; set; }
        public string? CompReteFechaEmision { get; set; }
        public string? CompReteAutorizacion { get; set; }
        public decimal BaseComision { get; set; }
        public bool IndBaseComision { get; set; }
        public bool? Inditem { get; set; }
        public bool? Indbu { get; set; }
        public string? XmlAdicionales { get; set; }
        public int? IdAplicacionesOrigen { get; set; }
        public decimal? Valormoneda1 { get; set; }
        public decimal? Valormoneda2 { get; set; }
        public decimal? Tasacambio1 { get; set; }
        public decimal? Tasacambio2 { get; set; }
        public string? CodigoPropiedad1 { get; set; }
        public string? CodigoPropiedad2 { get; set; }
        public string? CodigoPropiedad3 { get; set; }
        public string? CodigoPropiedad4 { get; set; }
        public string? CodigoPropiedad5 { get; set; }
        public bool? FactMovimientoOriginal { get; set; }
        public int? IdAplicacionesZeus { get; set; }
        public int? IdOrigenMovimiento { get; set; }
        public double? FactPorcentajeInteresPactado { get; set; }
        public double? FactPorcentajeInteresComparativo { get; set; }
        public decimal? FactIdencondicionesdecredito { get; set; }
        public int? Cuota { get; set; }
        public int? Plazo { get; set; }
        public decimal? ValorPrestamo { get; set; }
        public decimal? ValorCuota { get; set; }
        public decimal? CostosAsociados { get; set; }
        public int? CuotasGracia { get; set; }
        public decimal? ConsecutivoCredito { get; set; }
        public string? Revelacion { get; set; }
        public int? IdenSecciones { get; set; }
        public string? IdMovimiento { get; set; }
        public string? IdMonedaRelacion { get; set; }
        public decimal? ValorMonedaRelacion { get; set; }
        public double? TasaDeCambioMonedaRelacion { get; set; }
        public string? Nittrag { get; set; }
        public string? LineaImpuesto { get; set; }
        public string? SubLineaImpuesto { get; set; }
        public int? IdAgrupado { get; set; }
        public string? Adicional1TerceroDetallado { get; set; }
        public string? Adicional2TerceroDetallado { get; set; }
        public string? Adicional3TerceroDetallado { get; set; }
        public string? Adicional4TerceroDetallado { get; set; }
        public int? Indnumdoctra { get; set; }
        public bool? Indnumefacperu { get; set; }

        public virtual Bu BuNavigation { get; set; } = null!;
        public virtual Fuente IdfuenteNavigation { get; set; } = null!;
    }
}
