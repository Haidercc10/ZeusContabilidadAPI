using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class SunatConcepto
    {
        public string CodigoConcepto { get; set; } = null!;
        public string NombreConcepto { get; set; } = null!;
        public int IdenSunatConceptos { get; set; }
    }
}
