using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class RolesEntidadesNivel3
    {
        public RolesEntidadesNivel3()
        {
            RolesEntidadesNivel4s = new HashSet<RolesEntidadesNivel4>();
        }

        public decimal Iden { get; set; }
        public decimal RolEntidadNivel2 { get; set; }
        public string? ValorCadenaInicialIdentificador1 { get; set; }
        public string? ValorCadenaFinalIdentificador1 { get; set; }
        public decimal? ValorNumericInicialIdentificador1 { get; set; }
        public decimal? ValorNumericFinalIdentificador1 { get; set; }
        public string? ValorCadenaInicialIdentificador2 { get; set; }
        public string? ValorCadenaFinalIdentificador2 { get; set; }
        public decimal? ValorNumericInicialIdentificador2 { get; set; }
        public decimal? ValorNumericFinalIdentificador2 { get; set; }
        public bool? Todos { get; set; }

        public virtual RolesEntidadesNivel2 RolEntidadNivel2Navigation { get; set; } = null!;
        public virtual ICollection<RolesEntidadesNivel4> RolesEntidadesNivel4s { get; set; }
    }
}
