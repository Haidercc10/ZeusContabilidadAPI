using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class ConfiguracionesEspecifica
    {
        public decimal Iden { get; set; }
        public decimal? IdenOpcion { get; set; }
        public decimal? IdenCampo { get; set; }
        public string? ValorCampo { get; set; }
    }
}
