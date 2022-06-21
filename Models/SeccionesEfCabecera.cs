using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class SeccionesEfCabecera
    {
        public SeccionesEfCabecera()
        {
            InverseIdSeccionPadreNavigation = new HashSet<SeccionesEfCabecera>();
            SeccionesEfDetalles = new HashSet<SeccionesEfDetalle>();
            SeccionesEfExcepciones = new HashSet<SeccionesEfExcepcione>();
        }

        public int Id { get; set; }
        public string Codigo { get; set; } = null!;
        public string? Nombre { get; set; }
        public int IdLibroLegal { get; set; }
        public int IdCategoriaFinanciera { get; set; }
        public int? IdSeccionPadre { get; set; }
        public int? NOrden { get; set; }
        public int? Tipo { get; set; }
        public bool? MostrarCodigo { get; set; }
        public bool? MostrarDetalleCuentas { get; set; }
        public int? Margen { get; set; }
        public bool? Sangrado { get; set; }
        public int? IdTasasConversion { get; set; }
        public int? ImprimeLinea { get; set; }
        public string? RubroFinanciero { get; set; }

        public virtual LibrosLegale IdLibroLegalNavigation { get; set; } = null!;
        public virtual SeccionesEfCabecera? IdSeccionPadreNavigation { get; set; }
        public virtual ICollection<SeccionesEfCabecera> InverseIdSeccionPadreNavigation { get; set; }
        public virtual ICollection<SeccionesEfDetalle> SeccionesEfDetalles { get; set; }
        public virtual ICollection<SeccionesEfExcepcione> SeccionesEfExcepciones { get; set; }
    }
}
