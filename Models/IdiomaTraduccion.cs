using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class IdiomaTraduccion
    {
        public decimal Iden { get; set; }
        public decimal IdiomaDiccionarioIden { get; set; }
        public decimal IdiomaTiposIden { get; set; }
        public string Traduccion { get; set; } = null!;

        public virtual IdiomaDiccionario IdiomaDiccionarioIdenNavigation { get; set; } = null!;
        public virtual IdiomaTipo IdiomaTiposIdenNavigation { get; set; } = null!;
    }
}
