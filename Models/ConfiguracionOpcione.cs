using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class ConfiguracionOpcione
    {
        public int IdMenu { get; set; }
        public string Nombre { get; set; } = null!;
        public int Pariente { get; set; }
        public int Orden { get; set; }
        public decimal IdForma { get; set; }
        public bool? ExigeMotivo { get; set; }
        public bool MetodoPago { get; set; }
        public int IdenConfiguracionopciones { get; set; }
    }
}
