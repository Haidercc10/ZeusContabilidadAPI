using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class MfPagarePrestamoHead
    {
        public int Iden { get; set; }
        public int IdenConfPagare { get; set; }
        public int Consecutivo { get; set; }
        public decimal IdPrestamo { get; set; }
        public string CodCliente { get; set; } = null!;
        public string Fecha { get; set; } = null!;
        public string Vencimiento { get; set; } = null!;
        public decimal ValorPrestamo { get; set; }
        public decimal PorcInteres { get; set; }
        public int Plazo { get; set; }
        public decimal ValorCuota { get; set; }
        public string VencimientoCuota1 { get; set; } = null!;
        public string Estado { get; set; } = null!;
        public string Fuente { get; set; } = null!;
        public string Documento { get; set; } = null!;

        public virtual Cliente CodClienteNavigation { get; set; } = null!;
        public virtual Document Document { get; set; } = null!;
        public virtual Fuente FuenteNavigation { get; set; } = null!;
    }
}
