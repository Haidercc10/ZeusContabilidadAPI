using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class MensajesTiempo
    {
        public decimal Usuario { get; set; }
        public int? TiempoLecturaMensajes { get; set; }
        public int IdenMensajesTiempo { get; set; }
    }
}
