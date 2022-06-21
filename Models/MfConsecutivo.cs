using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class MfConsecutivo
    {
        public string Estudio { get; set; } = null!;
        public decimal? Consecutivo { get; set; }
        public string? Descripcion { get; set; }
        public int IdenMfConsecutivo { get; set; }
    }
}
