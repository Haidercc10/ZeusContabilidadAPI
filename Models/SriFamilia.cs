using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class SriFamilia
    {
        public int Iden { get; set; }
        public string Aplicativo { get; set; } = null!;
        public string Servidor { get; set; } = null!;
        public string Base { get; set; } = null!;
    }
}
