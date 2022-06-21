using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class MfTablapadre
    {
        public MfTablapadre()
        {
            MfCaptrabajos = new HashSet<MfCaptrabajo>();
            MfDatosnegocios = new HashSet<MfDatosnegocio>();
            MfDatosusuarioadis = new HashSet<MfDatosusuarioadi>();
            MfDeuda = new HashSet<MfDeuda>();
            MfEmpleados = new HashSet<MfEmpleado>();
            MfEstfinancieros = new HashSet<MfEstfinanciero>();
            MfFamilia = new HashSet<MfFamilium>();
            MfIngresos = new HashSet<MfIngreso>();
            MfInvactivos = new HashSet<MfInvactivo>();
            MfPresupuestos = new HashSet<MfPresupuesto>();
            MfProdvendusuarios = new HashSet<MfProdvendusuario>();
            MfProyinversions = new HashSet<MfProyinversion>();
            MfPygs = new HashSet<MfPyg>();
            MfReferencia = new HashSet<MfReferencium>();
        }

        public int IdTablamaestro { get; set; }
        public string Codusuario { get; set; } = null!;
        public string Fecha { get; set; } = null!;
        public string? Codasesor { get; set; }
        public string? Codzona { get; set; }
        public string Codgrupo { get; set; } = null!;
        public string? Codtiponegocio { get; set; }
        public decimal Solicitudcredito { get; set; }
        public decimal Contribucion { get; set; }
        public decimal TotalProyinv { get; set; }
        public string Estado { get; set; } = null!;
        public string FechaBalance { get; set; } = null!;
        public string TipoEstudio { get; set; } = null!;
        public string TipoCredito { get; set; } = null!;
        public decimal Nestudios { get; set; }
        public int IdenMfTablapadre { get; set; }

        public virtual Maevende? CodasesorNavigation { get; set; }
        public virtual MfTiponegocio? CodtiponegocioNavigation { get; set; }
        public virtual Maezona? CodzonaNavigation { get; set; }
        public virtual MfActivo MfActivo { get; set; } = null!;
        public virtual MfPasivo MfPasivo { get; set; } = null!;
        public virtual ICollection<MfCaptrabajo> MfCaptrabajos { get; set; }
        public virtual ICollection<MfDatosnegocio> MfDatosnegocios { get; set; }
        public virtual ICollection<MfDatosusuarioadi> MfDatosusuarioadis { get; set; }
        public virtual ICollection<MfDeuda> MfDeuda { get; set; }
        public virtual ICollection<MfEmpleado> MfEmpleados { get; set; }
        public virtual ICollection<MfEstfinanciero> MfEstfinancieros { get; set; }
        public virtual ICollection<MfFamilium> MfFamilia { get; set; }
        public virtual ICollection<MfIngreso> MfIngresos { get; set; }
        public virtual ICollection<MfInvactivo> MfInvactivos { get; set; }
        public virtual ICollection<MfPresupuesto> MfPresupuestos { get; set; }
        public virtual ICollection<MfProdvendusuario> MfProdvendusuarios { get; set; }
        public virtual ICollection<MfProyinversion> MfProyinversions { get; set; }
        public virtual ICollection<MfPyg> MfPygs { get; set; }
        public virtual ICollection<MfReferencium> MfReferencia { get; set; }
    }
}
