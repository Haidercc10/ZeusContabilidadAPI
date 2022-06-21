using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class GestionJob
    {
        public decimal NumId { get; set; }
        public string VchJob { get; set; } = null!;
        public string? Descripcion { get; set; }
        public string? Procedimiento { get; set; }
        public string? ParametroTiempoEspera { get; set; }
        public int IdenGestionjob { get; set; }
    }
}
