using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class MfFamilium
    {
        public int IdFamilia { get; set; }
        public int IdPadre { get; set; }
        public string Nombre { get; set; } = null!;
        public string Fechanac { get; set; } = null!;
        public string Sexo { get; set; } = null!;
        public string Idparentesco { get; set; } = null!;
        public string Estadocivil { get; set; } = null!;
        public string Estudios { get; set; } = null!;
        public decimal Aportefinal { get; set; }
        public string Ocupacionact { get; set; } = null!;
        public string TipoEstudio { get; set; } = null!;

        public virtual MfNivelescolaridad EstudiosNavigation { get; set; } = null!;
        public virtual MfParentesco IdparentescoNavigation { get; set; } = null!;
        public virtual MfTablapadre MfTablapadre { get; set; } = null!;
        public virtual MfProfesion OcupacionactNavigation { get; set; } = null!;
    }
}
