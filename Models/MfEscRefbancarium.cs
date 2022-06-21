using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class MfEscRefbancarium
    {
        public int IdRefbancaria { get; set; }
        public int IdescPadre { get; set; }
        public string Codbanco { get; set; } = null!;
        public string Cuenta { get; set; } = null!;
        public string Barrio { get; set; } = null!;
        public string Direccion { get; set; } = null!;
        public string Ciudad { get; set; } = null!;
        public string Telefono { get; set; } = null!;

        public virtual Banco CodbancoNavigation { get; set; } = null!;
        public virtual MfEscTablapadre IdescPadreNavigation { get; set; } = null!;
    }
}
