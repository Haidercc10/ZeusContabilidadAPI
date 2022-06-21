using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class Certificado
    {
        public string? Idcertificado { get; set; }
        public string? NombreCertificado { get; set; }
        public string? CodConcepto { get; set; }
        public string? Concepto { get; set; }
        public string? Cuenta { get; set; }
        public string? LugarDeclara { get; set; }
        public int IdenCertificados { get; set; }
    }
}
