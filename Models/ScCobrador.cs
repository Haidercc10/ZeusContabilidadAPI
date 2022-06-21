using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class ScCobrador
    {
        public ScCobrador()
        {
            FacturasVsCobroLogIdenCobradorActualNavigations = new HashSet<FacturasVsCobroLog>();
            FacturasVsCobroLogIdenCobradorAnteriorNavigations = new HashSet<FacturasVsCobroLog>();
            FacturasVsCobros = new HashSet<FacturasVsCobro>();
            ScCobradorBus = new HashSet<ScCobradorBu>();
            ScProgramacionClientes = new HashSet<ScProgramacionCliente>();
            ScProgramacions = new HashSet<ScProgramacion>();
        }

        public decimal Iden { get; set; }
        public string Codigo { get; set; } = null!;
        public string Nombre { get; set; } = null!;
        public string Direccion { get; set; } = null!;
        public string Telefono { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string Jefe { get; set; } = null!;
        public string JefeEmail { get; set; } = null!;
        public string Bu { get; set; } = null!;
        public string? Firma { get; set; }
        public int? Deshabilitado { get; set; }

        public virtual ICollection<FacturasVsCobroLog> FacturasVsCobroLogIdenCobradorActualNavigations { get; set; }
        public virtual ICollection<FacturasVsCobroLog> FacturasVsCobroLogIdenCobradorAnteriorNavigations { get; set; }
        public virtual ICollection<FacturasVsCobro> FacturasVsCobros { get; set; }
        public virtual ICollection<ScCobradorBu> ScCobradorBus { get; set; }
        public virtual ICollection<ScProgramacionCliente> ScProgramacionClientes { get; set; }
        public virtual ICollection<ScProgramacion> ScProgramacions { get; set; }
    }
}
