using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class Ger07general
    {
        public string Cuenta { get; set; } = null!;
        public string TipoCuenta { get; set; } = null!;
        public string FechaTransmision { get; set; } = null!;
        public int Cantidad { get; set; }
        public string Medida { get; set; } = null!;
        public string FechaAplicacion { get; set; } = null!;
        public int CantidadA { get; set; }
        public string MedidaA { get; set; } = null!;
        public string Enviar { get; set; } = null!;
        public string EnviarDecimales { get; set; } = null!;
        public string DigVerificacion { get; set; } = null!;
        public string EnviarRegistroCorreoE { get; set; } = null!;
        public int IdenGer07general { get; set; }
    }
}
