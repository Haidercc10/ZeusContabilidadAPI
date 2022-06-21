using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class GerBancoIndustrialGuatemalaProvTer
    {
        public string CodPrvTer { get; set; } = null!;
        public string Tipo { get; set; } = null!;
        public string? Tipocta { get; set; }
        public string? Numcta { get; set; }
        public string? Email { get; set; }
        public string CodigoMatricula { get; set; } = null!;
        public int Principal { get; set; }
        public int IdenGerbancoindustrialguatemalaProvter { get; set; }
    }
}
