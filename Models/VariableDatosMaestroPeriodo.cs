﻿using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class VariableDatosMaestroPeriodo
    {
        public decimal IdenMaestro { get; set; }
        public decimal IdenVariable { get; set; }
        public DateTime Fecha { get; set; }
        public string CodigoMaestro { get; set; } = null!;
        public decimal? ValorNumerico { get; set; }
        public DateTime? ValorFecha { get; set; }
        public string? ValorVarchar { get; set; }
        public int IdenVariabledatosmaestroperiodo { get; set; }

        public virtual VariableDefinicionMaestro IdenMaestroNavigation { get; set; } = null!;
        public virtual VariableDefinicion IdenVariableNavigation { get; set; } = null!;
    }
}
