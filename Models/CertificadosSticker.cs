using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class CertificadosSticker
    {
        public string CodCertificado { get; set; } = null!;
        public string FechaInicial { get; set; } = null!;
        public string FechaFinal { get; set; } = null!;
        public string NoDeclaracion { get; set; } = null!;
        public string NoSticker { get; set; } = null!;
        public string CodBanco { get; set; } = null!;
        public string FechaPresentacion { get; set; } = null!;
        public string FechaPago { get; set; } = null!;
        public int IdenCertificadosSticker { get; set; }
    }
}
