using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class DinnersDatosPoshotele
    {
        public decimal Iden { get; set; }
        public string IdAccionSoc { get; set; } = null!;
        public string Secuencia { get; set; } = null!;
        public string TipoRegistro { get; set; } = null!;
        public string NumeroTarjeta { get; set; } = null!;
        public string ValorTransaccion { get; set; } = null!;
        public string ValorBaseIva { get; set; } = null!;
        public string Iva { get; set; } = null!;
        public string ValorPropina { get; set; } = null!;
        public string ValorNeto { get; set; } = null!;
        public string NumeroCuotas { get; set; } = null!;
        public string FechaTransaccion { get; set; } = null!;
        public string CodigoEstablecimiento { get; set; } = null!;
        public string NumeroComprobante { get; set; } = null!;
        public string NumeroAutorizacion { get; set; } = null!;
        public string Codicta { get; set; } = null!;
        public string Cliprv { get; set; } = null!;
        public string Tipofac { get; set; } = null!;
        public string Numefac { get; set; } = null!;
        public string Vencefac { get; set; } = null!;
        public string Refefac { get; set; } = null!;
        public decimal BaseIvaCero { get; set; }
    }
}
