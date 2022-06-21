using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class Interfaz
    {
        public Interfaz()
        {
            InterfazCriterioGenericoDatos = new HashSet<InterfazCriterioGenericoDato>();
            InterfazCriterioTitulos = new HashSet<InterfazCriterioTitulo>();
            InterfazProcesos = new HashSet<InterfazProceso>();
        }

        public decimal Iden { get; set; }
        public string Codigo { get; set; } = null!;
        public string Nombre { get; set; } = null!;

        public virtual ICollection<InterfazCriterioGenericoDato> InterfazCriterioGenericoDatos { get; set; }
        public virtual ICollection<InterfazCriterioTitulo> InterfazCriterioTitulos { get; set; }
        public virtual ICollection<InterfazProceso> InterfazProcesos { get; set; }
    }
}
