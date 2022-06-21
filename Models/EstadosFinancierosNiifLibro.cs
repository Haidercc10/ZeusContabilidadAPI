using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class EstadosFinancierosNiifLibro
    {
        public EstadosFinancierosNiifLibro()
        {
            EstadosFinancierosNiifCabeceras = new HashSet<EstadosFinancierosNiifCabecera>();
        }

        public int Id { get; set; }
        public string CodLibro { get; set; } = null!;
        public string NomLibro { get; set; } = null!;
        public string? Reporte { get; set; }
        public string? StoredProcedure { get; set; }
        public string? SubReporte { get; set; }
        public string? Descripcion { get; set; }
        public bool Comparativo { get; set; }

        public virtual ICollection<EstadosFinancierosNiifCabecera> EstadosFinancierosNiifCabeceras { get; set; }
    }
}
