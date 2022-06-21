using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class ContDeterioroLog
    {
        public int Id { get; set; }
        public string? Idcliprv { get; set; }
        public string? Tipofactura { get; set; }
        public string? Numerofactura { get; set; }
        public string? Vencimientofactura { get; set; }
        public string? Referenciafactura { get; set; }
        public decimal? Saldo { get; set; }
        public decimal? Saldomoneda { get; set; }
        public decimal? Valordeterioro { get; set; }
        public string? Codicta { get; set; }
        public string? Bu { get; set; }
        public decimal? Valordeterioroacumulado { get; set; }
        public string? Fuente { get; set; }
        public string? Documento { get; set; }
    }
}
