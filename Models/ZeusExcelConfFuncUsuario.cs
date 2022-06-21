using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class ZeusExcelConfFuncUsuario
    {
        public int Id { get; set; }
        public string Usuario { get; set; } = null!;
        public string Aplicacion { get; set; } = null!;
        public string Nombre { get; set; } = null!;
        public string Formula { get; set; } = null!;
        public string Adicional { get; set; } = null!;
        public int? Uso { get; set; }
        public DateTime? FechaCreacion { get; set; }
        public DateTime? FechaModifico { get; set; }
        public bool? Activo { get; set; }
    }
}
