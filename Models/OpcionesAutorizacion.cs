using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class OpcionesAutorizacion
    {
        public int? IdMenu { get; set; }
        public string? Opcion { get; set; }
        public int IdenOpcionesautorizacion { get; set; }

        public virtual Menu? IdMenuNavigation { get; set; }
    }
}
