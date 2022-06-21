using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class FacturaElectronicaLiquidacionesdeCompra
    {
        public decimal Iden { get; set; }
        public string Fuente { get; set; } = null!;
        public string Documento { get; set; } = null!;
        public decimal? IdTransaccionFacturacionElectronica { get; set; }
        public DateTime? Fecha { get; set; }
        public string? Usuario { get; set; }

        public virtual FacturaElectronicaTransaccion? IdTransaccionFacturacionElectronicaNavigation { get; set; }
    }
}
