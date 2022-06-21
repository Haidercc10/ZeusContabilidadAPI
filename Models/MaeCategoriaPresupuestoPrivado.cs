using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class MaeCategoriaPresupuestoPrivado
    {
        public int Id { get; set; }
        public string Codigo { get; set; } = null!;
        public string Nombre { get; set; } = null!;
        public string? Descripcion { get; set; }
        public bool? DesHabilitar { get; set; }
        public bool? MultiplePresupuesto { get; set; }
        public bool? Adicion { get; set; }
        public bool? Disminucion { get; set; }
        public bool? Traslado { get; set; }
        public bool? Reserva { get; set; }
        public bool TrasladoMixto { get; set; }
    }
}
