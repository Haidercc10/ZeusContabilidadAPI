using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class FactHeadRelacionCompra
    {
        public decimal Id { get; set; }
        public string? FuenteFhe { get; set; }
        public string? DocumentoFhe { get; set; }
        public string? FuenteCompra { get; set; }
        public string? DocumentoCompra { get; set; }
    }
}
