using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class ExcelRemoto
    {
        public int Id { get; set; }
        public string Idcodigo { get; set; } = null!;
        public int Estado { get; set; }
        public byte[]? Filedesign { get; set; }
        public string FechaFunc { get; set; } = null!;
        public int Escala { get; set; }
        public string Origen { get; set; } = null!;
        public string? CentrosdeCosto { get; set; }
        public string? GrupoContable { get; set; }
        public string? Bodegas { get; set; }
        public string? Grupos { get; set; }
        public string? Parametros { get; set; }
        public string? Valores { get; set; }
        public string Caption { get; set; } = null!;
        public string? Error { get; set; }
    }
}
