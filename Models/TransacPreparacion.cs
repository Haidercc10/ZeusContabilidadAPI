using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class TransacPreparacion
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
        public string? ConseRelacionado { get; set; }
        public int Consecutivo { get; set; }
        public decimal BaseComision { get; set; }
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

        public virtual Fuente IdfuenteNavigation { get; set; } = null!;
    }
}
