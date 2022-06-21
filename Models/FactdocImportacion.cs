using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class FactdocImportacion
    {
        public decimal Iden { get; set; }
        public string FuenteImport { get; set; } = null!;
        public string DocumentoImport { get; set; } = null!;
        public string FuenteExport { get; set; } = null!;
        public string DocumentoExport { get; set; } = null!;
    }
}
