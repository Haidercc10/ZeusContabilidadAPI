using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class VMpgOppcuota
    {
        public int Iden { get; set; }
        public int IdenDocAsociado { get; set; }
        public int IdenCuota { get; set; }
        public decimal Valor { get; set; }
        public decimal Satisfecho { get; set; }
        public decimal Disminuciones { get; set; }
        public decimal Saldo { get; set; }
    }
}
