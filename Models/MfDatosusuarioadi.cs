using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class MfDatosusuarioadi
    {
        public int IdUsuarioadi { get; set; }
        public int IdPadre { get; set; }
        public string Codusuario { get; set; } = null!;
        public string Estadocivil { get; set; } = null!;
        public string Jefeflia { get; set; } = null!;
        public decimal Perscargo { get; set; }
        public string? Estudios { get; set; }
        public string? Idactividad { get; set; }
        public string Barriores { get; set; } = null!;
        public string Dirres { get; set; } = null!;
        public string Telres { get; set; } = null!;
        public string Tiempores { get; set; } = null!;
        public string Barrioneg { get; set; } = null!;
        public string Dirneg { get; set; } = null!;
        public string Telneg { get; set; } = null!;
        public string Tiemponeg { get; set; } = null!;
        public string TipoEstudio { get; set; } = null!;

        public virtual MfDatosusuario CodusuarioNavigation { get; set; } = null!;
        public virtual MfNivelescolaridad? EstudiosNavigation { get; set; }
        public virtual MfActividad? IdactividadNavigation { get; set; }
        public virtual MfTablapadre MfTablapadre { get; set; } = null!;
    }
}
