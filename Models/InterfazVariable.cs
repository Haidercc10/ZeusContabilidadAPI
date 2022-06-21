using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class InterfazVariable
    {
        public InterfazVariable()
        {
            InterfazAsignaVariables = new HashSet<InterfazAsignaVariable>();
            InterfazCombinacionDatos = new HashSet<InterfazCombinacionDato>();
        }

        public decimal Iden { get; set; }
        public string Codigo { get; set; } = null!;
        public string Nombre { get; set; } = null!;
        public string? Titulo { get; set; }
        public string? ListaPosibilidades { get; set; }
        public bool? SiAyuda { get; set; }
        public string? SeccionAyuda { get; set; }
        public bool? SiMaestroGenerico { get; set; }
        public bool? SiAyudaMaestroGenerico { get; set; }
        public string? SeccionAyudaMaestroGenerico { get; set; }
        public string? Adicional { get; set; }

        public virtual ICollection<InterfazAsignaVariable> InterfazAsignaVariables { get; set; }
        public virtual ICollection<InterfazCombinacionDato> InterfazCombinacionDatos { get; set; }
    }
}
