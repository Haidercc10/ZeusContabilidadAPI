using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class GerBancoNacionalCostaRicaProvTer
    {
        public string CodPrvTer { get; set; } = null!;
        public string Tipo { get; set; } = null!;
        public string? Oficina { get; set; }
        public string? Moneda { get; set; }
        public string? Producto { get; set; }
        public string? Numcta { get; set; }
        public int? Dvcta { get; set; }
        public string CodigoMatricula { get; set; } = null!;
        public int Principal { get; set; }
        public int IdenGerbanconacionalcostaricaProvter { get; set; }
    }
}
