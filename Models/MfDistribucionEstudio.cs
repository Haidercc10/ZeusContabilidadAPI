using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class MfDistribucionEstudio
    {
        public decimal Id { get; set; }
        public decimal Porcentaje { get; set; }
        public string Cuenta { get; set; } = null!;
        public string Descripcion { get; set; } = null!;
        public string Tipo { get; set; } = null!;
    }
}
