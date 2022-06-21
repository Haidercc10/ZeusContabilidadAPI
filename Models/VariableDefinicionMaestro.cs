using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class VariableDefinicionMaestro
    {
        public VariableDefinicionMaestro()
        {
            VariableDatosMaestroPeriodos = new HashSet<VariableDatosMaestroPeriodo>();
            VariableDatosMaestros = new HashSet<VariableDatosMaestro>();
            VariableDatosTransaccions = new HashSet<VariableDatosTransaccion>();
            VariableEstructuraVentanas = new HashSet<VariableEstructuraVentana>();
            VariableMaestros = new HashSet<VariableMaestro>();
            VariableRollOperacions = new HashSet<VariableRollOperacion>();
        }

        public decimal Iden { get; set; }
        public int IdenTipoVariable { get; set; }
        public int? IdenTipoTransaccion { get; set; }
        public string Codigo { get; set; } = null!;
        public string Nombre { get; set; } = null!;
        public string? Descripcion { get; set; }
        public string? Ventana { get; set; }
        public string? Tabla { get; set; }
        public string? CampoBusqueda { get; set; }
        public string? GrupoFormulacion { get; set; }
        public string? SpBrIni { get; set; }

        public virtual VariableTipoTransaccion? IdenTipoTransaccionNavigation { get; set; }
        public virtual ICollection<VariableDatosMaestroPeriodo> VariableDatosMaestroPeriodos { get; set; }
        public virtual ICollection<VariableDatosMaestro> VariableDatosMaestros { get; set; }
        public virtual ICollection<VariableDatosTransaccion> VariableDatosTransaccions { get; set; }
        public virtual ICollection<VariableEstructuraVentana> VariableEstructuraVentanas { get; set; }
        public virtual ICollection<VariableMaestro> VariableMaestros { get; set; }
        public virtual ICollection<VariableRollOperacion> VariableRollOperacions { get; set; }
    }
}
