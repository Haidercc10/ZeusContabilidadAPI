using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class Ger07pabGeneral
    {
        public string Cuenta { get; set; } = null!;
        public string TipoCuenta { get; set; } = null!;
        public string Aplicacion { get; set; } = null!;
        public string ClaseTransaccion { get; set; } = null!;
        public string Secuencia { get; set; } = null!;
        public string FechaTransmision { get; set; } = null!;
        public int Cantidad { get; set; }
        public string Medida { get; set; } = null!;
        public string FechaAplicacion { get; set; } = null!;
        public int CantidadA { get; set; }
        public string MedidaA { get; set; } = null!;
        public int IdenGer07pabgeneral { get; set; }
    }
}
