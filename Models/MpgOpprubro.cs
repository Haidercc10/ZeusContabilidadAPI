using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class MpgOpprubro
    {
        public int Iden { get; set; }
        public int IdenEntrada { get; set; }
        public int IdenItem { get; set; }
        public decimal Valor { get; set; }
        public decimal Satisfecho { get; set; }
        public decimal Disminuciones { get; set; }
        public decimal Saldo { get; set; }

        public virtual MpgOppentrada IdenEntradaNavigation { get; set; } = null!;
    }
}
