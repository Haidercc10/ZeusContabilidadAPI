using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class ArchivoFisicoDocumento
    {
        public int Iden { get; set; }
        public string CodigoArchivoFisico { get; set; } = null!;
        public string Fuente { get; set; } = null!;
        public string Documento { get; set; } = null!;
        public string Cuenta { get; set; } = null!;
        public string CliPrv { get; set; } = null!;
        public string TipoFactura { get; set; } = null!;
        public string NumeroFactura { get; set; } = null!;
        public string VencimientoFactura { get; set; } = null!;
        public string ReferenciaFactura { get; set; } = null!;

        public virtual ArchivoFisico CodigoArchivoFisicoNavigation { get; set; } = null!;
        public virtual Document Document { get; set; } = null!;
    }
}
