using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class InterfazCriterioGenericoDato
    {
        public decimal Iden { get; set; }
        public decimal InterfazIden { get; set; }
        public decimal TipoCriterio { get; set; }
        public string Codigo { get; set; } = null!;
        public string Nombre { get; set; } = null!;

        public virtual Interfaz InterfazIdenNavigation { get; set; } = null!;
    }
}
