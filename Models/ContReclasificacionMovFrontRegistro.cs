using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class ContReclasificacionMovFrontRegistro
    {
        public decimal Id { get; set; }
        public decimal IdReclasificacion { get; set; }
        public string IdRegistroFront { get; set; } = null!;
        public string Folio { get; set; } = null!;
        public string Clase { get; set; } = null!;
        public string TerceroNuevo { get; set; } = null!;
    }
}
