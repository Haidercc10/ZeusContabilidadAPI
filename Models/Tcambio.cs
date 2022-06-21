using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class Tcambio
    {
        public string Idmoneda { get; set; } = null!;
        public string Fecha { get; set; } = null!;
        public decimal Tasacambio { get; set; }
        public string Fechafinal { get; set; } = null!;
        public decimal TasaActivo { get; set; }
        public decimal TasaPasivo { get; set; }
        public decimal Iden { get; set; }
        public int Deshabilitado { get; set; }

        public virtual Moneda IdmonedaNavigation { get; set; } = null!;
    }
}
