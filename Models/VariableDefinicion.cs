using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class VariableDefinicion
    {
        public VariableDefinicion()
        {
            VariableDatosMaestroPeriodos = new HashSet<VariableDatosMaestroPeriodo>();
            VariableDatosMaestros = new HashSet<VariableDatosMaestro>();
            VariableDatosTransaccions = new HashSet<VariableDatosTransaccion>();
            VariableEstructuraControls = new HashSet<VariableEstructuraControl>();
            VariableMaestros = new HashSet<VariableMaestro>();
            VariableRollOperacions = new HashSet<VariableRollOperacion>();
        }

        public decimal Iden { get; set; }
        public string Nombre { get; set; } = null!;
        public string Presentacion { get; set; } = null!;
        public string? Descripcion { get; set; }
        public string TipoDato { get; set; } = null!;
        public decimal Tamano { get; set; }
        public decimal Presicion { get; set; }
        public decimal DefaultNumerico { get; set; }
        public DateTime? DefaultFecha { get; set; }
        public string? DefaultVarchar { get; set; }
        public int IdenTipoVariable { get; set; }
        public string TipoVariable { get; set; } = null!;
        public string SentenciaSql { get; set; } = null!;
        public bool ManejaAyuda { get; set; }
        public string? SeccionAyuda { get; set; }
        public string? ListaPosibilidades { get; set; }
        public string? OpcionalAyuda { get; set; }
        public string? RangoI { get; set; }
        public string? RangoF { get; set; }
        public DateTime FechaCreacion { get; set; }
        public bool Deshabilitado { get; set; }
        public bool Requerido { get; set; }
        public bool Bloqueado { get; set; }
        public bool UnicaSencilla { get; set; }
        public bool UnicaCompuesta { get; set; }
        public bool ValidacionGlobal { get; set; }
        public int? BuscadorGenerico { get; set; }
        public int? Formulada { get; set; }
        public string? FormulaDefault { get; set; }
        public int? RequeridoCero { get; set; }
        public int? HefestoIdF4 { get; set; }
        public string? HefestoDefaultFormulaFormat { get; set; }
        public int? HefestoOrderFormulaGlobal { get; set; }

        public virtual VariableTipoVariable IdenTipoVariableNavigation { get; set; } = null!;
        public virtual ICollection<VariableDatosMaestroPeriodo> VariableDatosMaestroPeriodos { get; set; }
        public virtual ICollection<VariableDatosMaestro> VariableDatosMaestros { get; set; }
        public virtual ICollection<VariableDatosTransaccion> VariableDatosTransaccions { get; set; }
        public virtual ICollection<VariableEstructuraControl> VariableEstructuraControls { get; set; }
        public virtual ICollection<VariableMaestro> VariableMaestros { get; set; }
        public virtual ICollection<VariableRollOperacion> VariableRollOperacions { get; set; }
    }
}
