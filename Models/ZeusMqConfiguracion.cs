using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class ZeusMqConfiguracion
    {
        public int Iden { get; set; }
        public string Nombre { get; set; } = null!;
        public string TopicMq { get; set; } = null!;
        public int EnvioSincrono { get; set; }
        public string Detalles { get; set; } = null!;
        public int Deshabilitado { get; set; }
        public string Aplicacion { get; set; } = null!;
        public int IdenZeusmqConfiguracion { get; set; }
    }
}
