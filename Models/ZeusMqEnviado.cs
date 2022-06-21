using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class ZeusMqEnviado
    {
        public decimal Iden { get; set; }
        public int IdenMqservidor { get; set; }
        public int IdenMqconfiguracion { get; set; }
        public string? Msg { get; set; }
        public string? Respuesta { get; set; }
        public DateTime FechaCreacion { get; set; }
        public Guid? IdUnico { get; set; }
    }
}
