using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class SriInfoTributarium
    {
        public decimal Iden { get; set; }
        public int Ambiente { get; set; }
        public int TipoEmision { get; set; }
        public string RazonSocial { get; set; } = null!;
        public string NombreComercial { get; set; } = null!;
        public string Ruc { get; set; } = null!;
        public string ClaveAcceso { get; set; } = null!;
        public string CodDoc { get; set; } = null!;
        public string Establecimiento { get; set; } = null!;
        public string PuntoEmision { get; set; } = null!;
        public string Secuencial { get; set; } = null!;
        public string DirMatriz { get; set; } = null!;
        public decimal IdenXmlRecibido { get; set; }
    }
}
