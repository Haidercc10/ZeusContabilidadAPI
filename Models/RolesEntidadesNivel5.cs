using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class RolesEntidadesNivel5
    {
        public decimal Iden { get; set; }
        public decimal RolEntidadNivel4 { get; set; }
        public string? ValorCadenaInicialIdentificador1 { get; set; }
        public string? ValorCadenaFinalIdentificador1 { get; set; }
        public decimal? ValorNumericInicialIdentificador1 { get; set; }
        public decimal? ValorNumericFinalIdentificador1 { get; set; }
        public string? ValorCadenaInicialIdentificador2 { get; set; }
        public string? ValorCadenaFinalIdentificador2 { get; set; }
        public decimal? ValorNumericInicialIdentificador2 { get; set; }
        public decimal? ValorNumericFinalIdentificador2 { get; set; }
        public bool? Todos { get; set; }

        public virtual RolesEntidadesNivel4 RolEntidadNivel4Navigation { get; set; } = null!;
    }
}
