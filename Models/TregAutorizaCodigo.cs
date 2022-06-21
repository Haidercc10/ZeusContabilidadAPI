using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class TregAutorizaCodigo
    {
        public decimal Iden { get; set; }
        public decimal IdSesion { get; set; }
        public decimal IdenMenu { get; set; }
        public string Usuario { get; set; } = null!;
        public string MiPc { get; set; } = null!;
        public decimal Codigo { get; set; }
        public DateTime FechaGen { get; set; }
        public int Verificado { get; set; }
    }
}
