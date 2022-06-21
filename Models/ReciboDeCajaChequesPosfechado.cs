using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class ReciboDeCajaChequesPosfechado
    {
        public string? Idfuente { get; set; }
        public string? Numdoctra { get; set; }
        public string? Fechatra { get; set; }
        public string? Codicta { get; set; }
        public string? Nittra { get; set; }
        public decimal? Valortra { get; set; }
        public string? Tipofac { get; set; }
        public string? Numefac { get; set; }
        public string? Vencefac { get; set; }
        public string? Refefac { get; set; }
        public string? Cliprv { get; set; }
        public string? Codictacja { get; set; }
        public string? Moneda { get; set; }
        public decimal Idregistro { get; set; }
        public string? Idbanco { get; set; }
        public string Bu { get; set; } = null!;
    }
}
