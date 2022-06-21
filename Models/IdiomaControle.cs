using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class IdiomaControle
    {
        public decimal Iden { get; set; }
        public string Forma { get; set; } = null!;
        public string TipoControl { get; set; } = null!;
        public string Control { get; set; } = null!;
        public int Indice { get; set; }
        public string Propiedad { get; set; } = null!;
        public decimal IdiomaDiccionarioIden { get; set; }
        public string Control2 { get; set; } = null!;
        public string Propiedad2 { get; set; } = null!;

        public virtual IdiomaDiccionario IdiomaDiccionarioIdenNavigation { get; set; } = null!;
    }
}
