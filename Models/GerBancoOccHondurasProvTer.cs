using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class GerBancoOccHondurasProvTer
    {
        public string CodPrvTer { get; set; } = null!;
        public string Tipo { get; set; } = null!;
        public string? Numcta { get; set; }
        public string CodigoMatricula { get; set; } = null!;
        public int Principal { get; set; }
        public int IdenGerbancoocchondurasProvter { get; set; }
    }
}
