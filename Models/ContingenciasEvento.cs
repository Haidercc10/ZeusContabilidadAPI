using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class ContingenciasEvento
    {
        public int Iden { get; set; }
        public string? CodigoContingencia { get; set; }
        public DateTime FechaInicio { get; set; }
        public bool Estado { get; set; }
        public string Descripcion { get; set; } = null!;
        public DateTime? FechaFinal { get; set; }

        public virtual Contingencia? CodigoContingenciaNavigation { get; set; }
    }
}
