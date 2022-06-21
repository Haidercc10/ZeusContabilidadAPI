using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class RolesEntidadesNivel2
    {
        public RolesEntidadesNivel2()
        {
            RolesEntidadesNivel3s = new HashSet<RolesEntidadesNivel3>();
        }

        public decimal Iden { get; set; }
        public decimal RolEntidadNivel1 { get; set; }
        public string? ValorCadenaInicialIdentificador1 { get; set; }
        public string? ValorCadenaFinalIdentificador1 { get; set; }
        public decimal? ValorNumericInicialIdentificador1 { get; set; }
        public decimal? ValorNumericFinalIdentificador1 { get; set; }
        public string? ValorCadenaInicialIdentificador2 { get; set; }
        public string? ValorCadenaFinalIdentificador2 { get; set; }
        public decimal? ValorNumericInicialIdentificador2 { get; set; }
        public decimal? ValorNumericFinalIdentificador2 { get; set; }
        public bool? Todos { get; set; }

        public virtual RolesEntidadesNivel1 RolEntidadNivel1Navigation { get; set; } = null!;
        public virtual ICollection<RolesEntidadesNivel3> RolesEntidadesNivel3s { get; set; }
    }
}
