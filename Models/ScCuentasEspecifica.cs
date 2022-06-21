using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class ScCuentasEspecifica
    {
        public int Iden { get; set; }
        public int? SpId { get; set; }
        public string? Usuario { get; set; }
        public int? IdenVentana { get; set; }
        public decimal? IdenScProgramacion { get; set; }
        public string? Cuenta { get; set; }
        public string? Tipo { get; set; }
    }
}
