using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class MfEscBienesraice
    {
        public int IdBienes { get; set; }
        public int IdescPadre { get; set; }
        public string Descripcion { get; set; } = null!;
        public string Ciudad { get; set; } = null!;
        public string Direccion { get; set; } = null!;
        public string Hipoteca { get; set; } = null!;
        public string Nescritura { get; set; } = null!;
        public string Fecha { get; set; } = null!;
        public string Notaria { get; set; } = null!;
        public string Nmatricula { get; set; } = null!;
        public string Fechareg { get; set; } = null!;

        public virtual MfEscTablapadre IdescPadreNavigation { get; set; } = null!;
    }
}
