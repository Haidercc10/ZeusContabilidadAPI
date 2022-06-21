using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class ConfigVencDetraccion
    {
        public string Tipo { get; set; } = null!;
        public int DiaPagoDetraccion { get; set; }
        public int DiasIgual { get; set; }
        public int DiasMayor { get; set; }
        public int DiasMenor { get; set; }
        public bool MayorIgual { get; set; }
        public bool MenorIgual { get; set; }
        public string TipoDetra { get; set; } = null!;
        public int IdenConfigvencdetraccion { get; set; }
    }
}
