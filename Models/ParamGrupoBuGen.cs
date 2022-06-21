using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class ParamGrupoBuGen
    {
        public decimal Idparam { get; set; }
        public string? Usuario { get; set; }
        public decimal? Idreporte { get; set; }
        public string? Tipo { get; set; }
    }
}
