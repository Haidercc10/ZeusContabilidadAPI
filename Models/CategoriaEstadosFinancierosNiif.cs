using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class CategoriaEstadosFinancierosNiif
    {
        public CategoriaEstadosFinancierosNiif()
        {
            EstadosFinancierosNiifCabeceras = new HashSet<EstadosFinancierosNiifCabecera>();
        }

        public int Id { get; set; }
        public string Codigo { get; set; } = null!;
        public string Nombre { get; set; } = null!;
        public int Deshabilitado { get; set; }

        public virtual ICollection<EstadosFinancierosNiifCabecera> EstadosFinancierosNiifCabeceras { get; set; }
    }
}
