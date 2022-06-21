using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class EsquemaErrorTransac
    {
        public string Fuente { get; set; } = null!;
        public string Documento { get; set; } = null!;
        public string Usuario { get; set; } = null!;
        public DateTime FechaProceso { get; set; }
        public int Consecutra { get; set; }
        public decimal IdenEsquemaTransaccion { get; set; }
        public int IdenEsquemaErrorTransac { get; set; }
    }
}
