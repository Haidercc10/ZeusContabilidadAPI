using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class MfDatosusuario
    {
        public MfDatosusuario()
        {
            MfDatosusuarioadis = new HashSet<MfDatosusuarioadi>();
            MfEscTablapadres = new HashSet<MfEscTablapadre>();
            MfPolizas = new HashSet<MfPoliza>();
            MfRenovacionCreditos = new HashSet<MfRenovacionCredito>();
        }

        public int IdUsuario { get; set; }
        public string Codusuario { get; set; } = null!;
        public string Nombre { get; set; } = null!;
        public string Cedula { get; set; } = null!;
        public string Expedida { get; set; } = null!;
        public string Sexo { get; set; } = null!;
        public string Fechanac { get; set; } = null!;
        public string Lugar { get; set; } = null!;
        public string Codzona { get; set; } = null!;
        public string Barriores { get; set; } = null!;
        public string Dirres { get; set; } = null!;
        public string Telres { get; set; } = null!;
        public string Ciudadres { get; set; } = null!;
        public string Barrioneg { get; set; } = null!;
        public string Dirneg { get; set; } = null!;
        public string Telneg { get; set; } = null!;
        public string Ciudadneg { get; set; } = null!;
        public string Codgrupo { get; set; } = null!;
        public string? TipoUsuario { get; set; }
        public string? TipoIdentificacion { get; set; }
        public string? Nombre1 { get; set; }
        public string? Nombre2 { get; set; }
        public string? Apellido1 { get; set; }
        public string? Apellido2 { get; set; }
        public string? TipoRazonSocial { get; set; }
        public int Lider { get; set; }
        public string CodAsesor { get; set; } = null!;
        public string Cxc { get; set; } = null!;

        public virtual ICollection<MfDatosusuarioadi> MfDatosusuarioadis { get; set; }
        public virtual ICollection<MfEscTablapadre> MfEscTablapadres { get; set; }
        public virtual ICollection<MfPoliza> MfPolizas { get; set; }
        public virtual ICollection<MfRenovacionCredito> MfRenovacionCreditos { get; set; }
    }
}
