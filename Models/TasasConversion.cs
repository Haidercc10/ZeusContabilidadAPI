using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class TasasConversion
    {
        public TasasConversion()
        {
            EstadosFinancierosNiifCabeceras = new HashSet<EstadosFinancierosNiifCabecera>();
        }

        public int Id { get; set; }
        public string Codigo { get; set; } = null!;
        public string Nombre { get; set; } = null!;

        public virtual ICollection<EstadosFinancierosNiifCabecera> EstadosFinancierosNiifCabeceras { get; set; }
    }
}
