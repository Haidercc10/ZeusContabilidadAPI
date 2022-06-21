using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class MensajesUsuario
    {
        public string? Evento { get; set; }
        public decimal? Usuario { get; set; }
        public decimal? Remitente { get; set; }
        public bool? EmailExterno { get; set; }
        public int IdenMensajesUsuarios { get; set; }
    }
}
