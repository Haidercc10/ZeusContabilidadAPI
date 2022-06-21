using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class InterfazCriterioTitulo
    {
        public decimal Iden { get; set; }
        public decimal InterfazIden { get; set; }
        public decimal TipoCriterio { get; set; }
        public string Titulo { get; set; } = null!;

        public virtual Interfaz InterfazIdenNavigation { get; set; } = null!;
    }
}
