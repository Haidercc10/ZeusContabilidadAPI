using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class LibrosLegale
    {
        public LibrosLegale()
        {
            SeccionesEfCabeceras = new HashSet<SeccionesEfCabecera>();
        }

        public int Id { get; set; }
        public string CodLibro { get; set; } = null!;
        public string NomLibro { get; set; } = null!;
        public string? Reporte { get; set; }
        public string? StoredProcedure { get; set; }
        public string? SubReporte { get; set; }
        public string? Descripcion { get; set; }
        public bool Comparativo { get; set; }
        public bool? EsNiif { get; set; }
        public bool? ModeloDbCr { get; set; }

        public virtual ICollection<SeccionesEfCabecera> SeccionesEfCabeceras { get; set; }
    }
}
