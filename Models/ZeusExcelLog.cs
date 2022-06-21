using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class ZeusExcelLog
    {
        public int Id { get; set; }
        public string? Metodo { get; set; }
        public string? Menu { get; set; }
        public string? Descripcion { get; set; }
        public string? Usuario { get; set; }
        public string? Host { get; set; }
        public DateTime? Fecha { get; set; }
    }
}
