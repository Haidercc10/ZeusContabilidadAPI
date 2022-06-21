using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class PerfilTemp
    {
        public string Perfil { get; set; } = null!;
        public int Opcion { get; set; }
        public string NameOpcion { get; set; } = null!;
        public string? Descripcion { get; set; }
    }
}
