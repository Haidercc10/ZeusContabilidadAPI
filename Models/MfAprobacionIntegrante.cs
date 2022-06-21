using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class MfAprobacionIntegrante
    {
        public int IdComite { get; set; }
        public string CodAsesor { get; set; } = null!;
        public int IdenMfAprobacionintegrantes { get; set; }
    }
}
