using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class DinnerMovimiento
    {
        public int Id { get; set; }
        public int? IdDinner { get; set; }
        public bool? Seleccion { get; set; }
        public string? IdCliPrv { get; set; }
        public string? NombreCliente { get; set; }
        public string? NumeroTarjeta { get; set; }
        public decimal? ValorTransaccion { get; set; }
        public decimal? BaseIva { get; set; }
        public decimal? Iva { get; set; }
        public decimal? Propina { get; set; }
        public decimal? Neto { get; set; }
        public short? NoCuotas { get; set; }
        public DateTime? FechaTransaccion { get; set; }
        public string? CodigoEstablecimiento { get; set; }
        public string? NroComprobante { get; set; }
        public string? NroAutorizacion { get; set; }
        public string? Codicta { get; set; }
        public string? Tipofac { get; set; }
        public string? Numefac { get; set; }
        public string? Refefac { get; set; }
        public string? Vencefac { get; set; }
        public string? Bu { get; set; }
        public string? FuenteRecaudo { get; set; }
        public string? DocumentoRecaudo { get; set; }
        public decimal BaseIvaCero { get; set; }

        public virtual Dinner? IdDinnerNavigation { get; set; }
    }
}
