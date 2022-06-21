using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class DocumentCheque
    {
        public decimal Iden { get; set; }
        public string Fuente { get; set; } = null!;
        public string Documento { get; set; } = null!;
        public string Cuenta { get; set; } = null!;
        public string Moneda { get; set; } = null!;
        public string NumeroCheque { get; set; } = null!;
        public string Vencimiento { get; set; } = null!;
        public decimal Valor { get; set; }
        public string Beneficiario { get; set; } = null!;
        public string Estado { get; set; } = null!;
        public string Entregado { get; set; } = null!;
        public string TipoDocEntrega { get; set; } = null!;
        public string NumDocEntrega { get; set; } = null!;
        public DateTime FechaEntrega { get; set; }
        public string ImpriCheque { get; set; } = null!;
        public string Montoletras { get; set; } = null!;
        public decimal VrMoneda { get; set; }
        public string MontoMoneda { get; set; } = null!;
        public string AreaEmpresa { get; set; } = null!;
        public DateTime FechaEntregaAreaEmpresa { get; set; }
        public bool ChequeEntregado { get; set; }
        public string CodTipoIdentificacion { get; set; } = null!;
    }
}
