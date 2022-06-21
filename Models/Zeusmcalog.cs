using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class Zeusmcalog
    {
        public string? Usuario { get; set; }
        public string? Operacion { get; set; }
        public string? Fecha { get; set; }
        public string? Descripcion { get; set; }
        public int Id { get; set; }
        public string? Idaplicacion { get; set; }
        public string? Tipooperacion { get; set; }
        public string? Explicacion { get; set; }
    }
}
