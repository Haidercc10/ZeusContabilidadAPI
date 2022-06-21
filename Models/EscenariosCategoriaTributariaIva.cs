using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class EscenariosCategoriaTributariaIva
    {
        public decimal Iden { get; set; }
        public string Nombre { get; set; } = null!;
        public int IdenEscenariosCategoriatributariaiva { get; set; }
    }
}
