using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class CfDivision
    {
        public int Iden { get; set; }
        public string Codigo { get; set; } = null!;
        public string Nombre { get; set; } = null!;
    }
}
