using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class PostFechadosConfiguracion
    {
        public long Iden { get; set; }
        public string Tipo { get; set; } = null!;
        public string Codigo { get; set; } = null!;
    }
}
