using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class RolesEntidadesNivel1
    {
        public RolesEntidadesNivel1()
        {
            RolesEntidadesNivel2s = new HashSet<RolesEntidadesNivel2>();
        }

        public decimal Iden { get; set; }
        public decimal RolEntidadNivel0 { get; set; }
        public string? ValorCadenaInicialIdentificador1 { get; set; }
        public string? ValorCadenaFinalIdentificador1 { get; set; }
        public decimal? ValorNumericInicialIdentificador1 { get; set; }
        public decimal? ValorNumericFinalIdentificador1 { get; set; }
        public string? ValorCadenaInicialIdentificador2 { get; set; }
        public string? ValorCadenaFinalIdentificador2 { get; set; }
        public decimal? ValorNumericInicialIdentificador2 { get; set; }
        public decimal? ValorNumericFinalIdentificador2 { get; set; }
        public bool? Todos { get; set; }

        public virtual RolesRegla RolEntidadNivel0Navigation { get; set; } = null!;
        public virtual ICollection<RolesEntidadesNivel2> RolesEntidadesNivel2s { get; set; }
    }
}
