using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class Maepresu
    {
        public string Codicta { get; set; } = null!;
        public string? Desccta { get; set; }
        public byte? Nivelcta { get; set; }
        public string? Tipocta { get; set; }
        public string? Coddcta { get; set; }
        public DateTime? Feapcta { get; set; }
        public int? Ncdpgcta { get; set; }
        public string Codpresu { get; set; } = null!;
        public string Definicion { get; set; } = null!;
        public string? Estado { get; set; }
        public string? UsuarioAutoriza { get; set; }
        public string? TipoPresu { get; set; }
        public string ControlPresu { get; set; } = null!;
        public byte[] VersionDeLaFila { get; set; } = null!;
        public int IdenMaepresu { get; set; }
    }
}
