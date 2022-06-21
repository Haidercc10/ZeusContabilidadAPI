using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class ZeusMySatComEcCodPorcImp
    {
        public int Iden { get; set; }
        public string CodigoImp { get; set; } = null!;
        public decimal PorcImp { get; set; }
        public string CodigoPorcImp { get; set; } = null!;
        public int Deshabilitado { get; set; }
    }
}
