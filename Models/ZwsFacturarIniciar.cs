using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class ZwsFacturarIniciar
    {
        public int Id { get; set; }
        public short? SpId { get; set; }
        public DateTime? Fecha { get; set; }
    }
}
