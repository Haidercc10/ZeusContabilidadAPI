using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class ContPppProgramacionesFactura
    {
        public decimal Iden { get; set; }
        public decimal IdenProgramacion { get; set; }
        public string Idcliprv { get; set; } = null!;
        public string? Tipofactura { get; set; }
        public string? Numerofactura { get; set; }
        public string? Vencimientofactura { get; set; }
        public string? Referenciafactura { get; set; }
        public string? Fechafactura { get; set; }
        public decimal? Saldo { get; set; }
        public decimal? Saldomoneda { get; set; }
        public decimal? Valorprogramado { get; set; }
        public string? Codicta { get; set; }
        public string? Bu { get; set; }
        public bool? Estado { get; set; }
        public bool? Conciliado { get; set; }
        public string? Codigomatriculagerencia { get; set; }
        public decimal? ValorPagoFactura { get; set; }
        public decimal? ValorPagoFacturaMoneda { get; set; }
        public decimal? ValorPagoFacturaMonedaContraPartida { get; set; }
        public decimal? ValorPagoFacturaAjusteMoneda { get; set; }
        public decimal? TasaCambio { get; set; }
        public string Item { get; set; } = null!;
        public decimal? IdenMetodoPago { get; set; }
        public int EstadoConciliacion { get; set; }
        public string FuenteConciliacion { get; set; } = null!;
        public string DocumentoConciliacion { get; set; } = null!;
        public decimal EstadoAprobacion { get; set; }
        public string GeneraRetencion { get; set; } = null!;
        public decimal? IdenNuevaProgramacion { get; set; }
        public string? PagInterBanc { get; set; }
        public decimal Opp { get; set; }
        public int Extornado { get; set; }
        public string? FuenteExtorno { get; set; }
        public string? DocumentoExtorno { get; set; }

        public virtual ContPppProgramacione IdenProgramacionNavigation { get; set; } = null!;
    }
}
