using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class ZeusFwQueryPropiedadesStoredProcedure
    {
        public ZeusFwQueryPropiedadesStoredProcedure()
        {
            ZeusFwQueryPropiedadesParametros = new HashSet<ZeusFwQueryPropiedadesParametro>();
        }

        public decimal IdQueryPropiedadesStoredProcedure { get; set; }
        public string NmStoredProcedure { get; set; } = null!;
        public string? DsDescripcionProcedure { get; set; }
        public string? NmNombreReporte { get; set; }
        public decimal? IdEntornoDatos { get; set; }
        public decimal? IdUsuario { get; set; }
        public string? DsLoginUsuario { get; set; }

        public virtual ICollection<ZeusFwQueryPropiedadesParametro> ZeusFwQueryPropiedadesParametros { get; set; }
    }
}
