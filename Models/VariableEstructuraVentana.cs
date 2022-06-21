using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class VariableEstructuraVentana
    {
        public decimal Iden { get; set; }
        public decimal? IdenMaestro { get; set; }
        public int Constante { get; set; }
        public string Titulo { get; set; } = null!;
        public string? ColorFondo { get; set; }
        public int Alto { get; set; }
        public int Ancho { get; set; }

        public virtual VariableDefinicionMaestro? IdenMaestroNavigation { get; set; }
    }
}
