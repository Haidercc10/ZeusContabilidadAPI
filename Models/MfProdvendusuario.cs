using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class MfProdvendusuario
    {
        public int IdProdvendusu { get; set; }
        public int IdPadre { get; set; }
        public string Codprodvender { get; set; } = null!;
        public string TipoEstudio { get; set; } = null!;

        public virtual MfProdvender CodprodvenderNavigation { get; set; } = null!;
        public virtual MfTablapadre MfTablapadre { get; set; } = null!;
    }
}
