using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class FbancolombiaProcesado
    {
        public string Idfuente { get; set; } = null!;
        public string Numdoctra { get; set; } = null!;
        public string Fecha { get; set; } = null!;
        public string Secuencia { get; set; } = null!;
        public int IdenFbancolombiaProcesados { get; set; }
    }
}
