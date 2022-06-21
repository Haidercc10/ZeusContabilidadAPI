using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class Area
    {
        public Area()
        {
            Documents = new HashSet<Document>();
        }

        public decimal Iden { get; set; }
        public string Codigo { get; set; } = null!;
        public string Nombre { get; set; } = null!;
        public string Descripcion { get; set; } = null!;
        public string TipoDoc { get; set; } = null!;
        public string Identificacion { get; set; } = null!;
        public string NombreResponsable { get; set; } = null!;
        public bool Deshabilitado { get; set; }
        public string? CodTipoIdentificacion { get; set; }

        public virtual ICollection<Document> Documents { get; set; }
    }
}
