using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class AplicacionesFuncione
    {
        public int Id { get; set; }
        public int IdAplicacionesZeus { get; set; }
        public string Nombre { get; set; } = null!;
        public string Funcion { get; set; } = null!;
        public string Descripcion { get; set; } = null!;
        public int Tipo { get; set; }
    }
}
