using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class SeccionesEfExcepcione
    {
        public int Id { get; set; }
        public int IdSeccionCabecera { get; set; }
        public string CodCta { get; set; } = null!;
        public string NomCta { get; set; } = null!;

        public virtual SeccionesEfCabecera IdSeccionCabeceraNavigation { get; set; } = null!;
    }
}
