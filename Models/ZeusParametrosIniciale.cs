using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class ZeusParametrosIniciale
    {
        public int Iden { get; set; }
        public string Nombre { get; set; } = null!;
        public string? Titulo { get; set; }
        public string? DescripcionGeneral { get; set; }
        public string? DescripcionTipica { get; set; }
        public string? DescripcionPersonalizada { get; set; }
        public bool? ActivarConfTipica { get; set; }
        public bool? ActivarConfPersonalizada { get; set; }
        public string? ExecSqlTipica { get; set; }
        public int? IdForma { get; set; }
        public int? Orden { get; set; }
        public DateTime? FechaProceso { get; set; }
        public string? ConfiguracionAplicada { get; set; }
        public string? ListaParametrosGenerales { get; set; }
    }
}
