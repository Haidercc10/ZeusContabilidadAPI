using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class EstadosFinancierosNiifCabecera
    {
        public EstadosFinancierosNiifCabecera()
        {
            EstadosFinancierosNiifDetalles = new HashSet<EstadosFinancierosNiifDetalle>();
            InverseIdEstadosFinancierosNiifCabeceraPadreNavigation = new HashSet<EstadosFinancierosNiifCabecera>();
        }

        public int Id { get; set; }
        public string Codigo { get; set; } = null!;
        public string Nombre { get; set; } = null!;
        public int IdEstadosFinancierosNiifLibros { get; set; }
        public int IdCategoriaEstadosFinancierosNiif { get; set; }
        public int? IdEstadosFinancierosNiifCabeceraPadre { get; set; }
        public int? IdTasasConversion { get; set; }

        public virtual CategoriaEstadosFinancierosNiif IdCategoriaEstadosFinancierosNiifNavigation { get; set; } = null!;
        public virtual EstadosFinancierosNiifCabecera? IdEstadosFinancierosNiifCabeceraPadreNavigation { get; set; }
        public virtual EstadosFinancierosNiifLibro IdEstadosFinancierosNiifLibrosNavigation { get; set; } = null!;
        public virtual TasasConversion? IdTasasConversionNavigation { get; set; }
        public virtual ICollection<EstadosFinancierosNiifDetalle> EstadosFinancierosNiifDetalles { get; set; }
        public virtual ICollection<EstadosFinancierosNiifCabecera> InverseIdEstadosFinancierosNiifCabeceraPadreNavigation { get; set; }
    }
}
