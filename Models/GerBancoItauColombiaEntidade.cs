using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class GerBancoItauColombiaEntidade
    {
        public decimal Iden { get; set; }
        public string IdBanco { get; set; } = null!;
        public string CodigoEntidad { get; set; } = null!;
    }
}
