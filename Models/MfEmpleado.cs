using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class MfEmpleado
    {
        public int IdEmpleado { get; set; }
        public int IdPadre { get; set; }
        public string Nombre { get; set; } = null!;
        public string Fechanac { get; set; } = null!;
        public string Sexo { get; set; } = null!;
        public string Estadocivil { get; set; } = null!;
        public string Barrio { get; set; } = null!;
        public string Direccion { get; set; } = null!;
        public string Ciudad { get; set; } = null!;
        public string Telefono { get; set; } = null!;
        public string Profesion { get; set; } = null!;
        public string Condicion { get; set; } = null!;
        public string Tipo { get; set; } = null!;
        public string TipoEstudio { get; set; } = null!;

        public virtual MfTablapadre MfTablapadre { get; set; } = null!;
        public virtual MfProfesion ProfesionNavigation { get; set; } = null!;
    }
}
