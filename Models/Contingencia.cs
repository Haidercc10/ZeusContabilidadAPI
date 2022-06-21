using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class Contingencia
    {
        public Contingencia()
        {
            ContingenciasEventos = new HashSet<ContingenciasEvento>();
            ContingenciasFuentes = new HashSet<ContingenciasFuente>();
        }

        public int IdContingencias { get; set; }
        public string Codigo { get; set; } = null!;
        public string Nombre { get; set; } = null!;
        public string? Descripcion { get; set; }
        public string Tipo { get; set; } = null!;
        public string? FuenteTal { get; set; }
        public string? SerieTal { get; set; }
        public DateTime? FechaInicio { get; set; }
        public DateTime? FechaFin { get; set; }
        public string? Estado { get; set; }

        public virtual ICollection<ContingenciasEvento> ContingenciasEventos { get; set; }
        public virtual ICollection<ContingenciasFuente> ContingenciasFuentes { get; set; }
    }
}
