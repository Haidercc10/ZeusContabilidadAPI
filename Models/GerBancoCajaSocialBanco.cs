using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class GerBancoCajaSocialBanco
    {
        public int Id { get; set; }
        public string Codigo { get; set; } = null!;
        public string Nombre { get; set; } = null!;
    }
}
