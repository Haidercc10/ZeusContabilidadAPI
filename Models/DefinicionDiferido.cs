using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class DefinicionDiferido
    {
        public int Iden { get; set; }
        public string Fechatra { get; set; } = null!;
        public DateTime Fecha { get; set; }
        public string Idfuente { get; set; } = null!;
        public string Numdoctra { get; set; } = null!;
        public int Consecutra { get; set; }
        public string Codicta { get; set; } = null!;
        public string Descritra { get; set; } = null!;
        public decimal Valortra { get; set; }
        public string Estado { get; set; } = null!;
    }
}
