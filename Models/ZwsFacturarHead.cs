using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class ZwsFacturarHead
    {
        public int Spid { get; set; }
        public decimal Iden { get; set; }
        public int? Tipo { get; set; }
        public string CliPrv { get; set; } = null!;
        public string? Fecha { get; set; }
        public int? FormaPago { get; set; }
        public string? CxcCxp { get; set; }
        public string? CentroCosto { get; set; }
        public string? Vendedor { get; set; }
        public string? TipoFac { get; set; }
        public string? NumeFac { get; set; }
        public string? VenceFac { get; set; }
        public string? RefeFac { get; set; }
        public string? Fuente { get; set; }
        public string? Documento { get; set; }
        public string? Descripcion { get; set; }
        public string Bu { get; set; } = null!;
        public string Ncf { get; set; } = null!;
        public bool Valera { get; set; }
        public string? FuenteImportada { get; set; }
        public string? DocumentoImportado { get; set; }
        public string? Observaciones { get; set; }
        public string? Ncfmodificado { get; set; }
        public decimal? TasaCambio { get; set; }
        public string? FacturaRel { get; set; }
        public string? TipoFacturaRel { get; set; }
        public string? FechaFactura { get; set; }
        public string? BienRete { get; set; }
        public string NumeroOrdenCompra { get; set; } = null!;

        public virtual Bu BuNavigation { get; set; } = null!;
    }
}
