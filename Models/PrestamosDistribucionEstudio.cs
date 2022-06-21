using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class PrestamosDistribucionEstudio
    {
        public int Id { get; set; }
        public string CodPrestamo { get; set; } = null!;
        public decimal Porcentaje { get; set; }
        public string Cuenta { get; set; } = null!;
        public string Descripcion { get; set; } = null!;
    }
}
