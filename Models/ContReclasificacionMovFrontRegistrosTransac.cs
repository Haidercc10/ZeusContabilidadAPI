using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class ContReclasificacionMovFrontRegistrosTransac
    {
        public decimal Id { get; set; }
        public decimal IdRegistroReclasificacion { get; set; }
        public int? Consecutra { get; set; }
        public int? ConsecutraNuevo { get; set; }
    }
}
