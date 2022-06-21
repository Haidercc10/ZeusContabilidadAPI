using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class EscenariosDocumento
    {
        public decimal Iden { get; set; }
        public DateTime Fecha { get; set; }
        public string? Fuente { get; set; }
        public string? Documento { get; set; }
        public string Tercero { get; set; } = null!;
        public decimal EscenariosPaisIden { get; set; }
        public string Moneda { get; set; } = null!;
        public decimal TasaCambio { get; set; }
        public string Modulo { get; set; } = null!;
        public string TipoOperacion { get; set; } = null!;
        public decimal? TotalBruto { get; set; }
        public decimal? TotalIva { get; set; }
        public decimal? TotalInc { get; set; }
        public decimal? TotalRetencion { get; set; }
        public decimal? Total { get; set; }
        public decimal? TotalBrutoMoneda { get; set; }
        public decimal? TotalIvamoneda { get; set; }
        public decimal? TotalIncmoneda { get; set; }
        public decimal? TotalRetencionMoneda { get; set; }
        public decimal? TotalMoneda { get; set; }
        public int? QuitarRetenciones { get; set; }
        public int? QuitarImpuestoPagado { get; set; }
        public int? QuitarImpuestoNoPagado { get; set; }
        public int? QuitarMayorValor { get; set; }

        public virtual Paise EscenariosPaisIdenNavigation { get; set; } = null!;
    }
}
