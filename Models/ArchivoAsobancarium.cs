using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class ArchivoAsobancarium
    {
        public long Id { get; set; }
        public int? Row { get; set; }
        public string? Registro { get; set; }
        public string? Error { get; set; }
        public int? Formato { get; set; }
        public int? SpId { get; set; }
    }
}
