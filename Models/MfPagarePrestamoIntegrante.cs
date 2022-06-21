using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class MfPagarePrestamoIntegrante
    {
        public int Iden { get; set; }
        public int IdenPagarePrestamoHead { get; set; }
        public string CodCliente { get; set; } = null!;
        public decimal Monto { get; set; }
        public decimal Porcentaje { get; set; }
        public decimal VrCuota { get; set; }

        public virtual Cliente CodClienteNavigation { get; set; } = null!;
    }
}
