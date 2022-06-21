using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class VariableDatosTransaccion
    {
        public decimal IdenMaestro { get; set; }
        public decimal IdenVariable { get; set; }
        public decimal ConsecutivoTrans { get; set; }
        public string CodigoMaestro { get; set; } = null!;
        public string CampoLibre { get; set; } = null!;
        public decimal? ValorNumerico { get; set; }
        public DateTime? ValorFecha { get; set; }
        public string? ValorVarchar { get; set; }
        public short? SpId { get; set; }
        public int IdenVariabledatostransaccion { get; set; }

        public virtual VariableDefinicionMaestro IdenMaestroNavigation { get; set; } = null!;
        public virtual VariableDefinicion IdenVariableNavigation { get; set; } = null!;
    }
}
