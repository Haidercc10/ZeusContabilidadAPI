using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class SunatRetencione
    {
        public string IndCuenta { get; set; } = null!;
        public string DescCuenta { get; set; } = null!;
        public string IndNombreComprobante { get; set; } = null!;
        public string NombreComprobante { get; set; } = null!;
        public string IndNombreTransaccion { get; set; } = null!;
        public string NombreTransaccion { get; set; } = null!;
        public int IdenSunatRetenciones { get; set; }
    }
}
