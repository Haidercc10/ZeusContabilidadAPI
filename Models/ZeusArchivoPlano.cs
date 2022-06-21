using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class ZeusArchivoPlano
    {
        public short Spid { get; set; }
        public decimal Linea { get; set; }
        public string Texto { get; set; } = null!;
        public int IdenZeusarchivoplano { get; set; }
    }
}
