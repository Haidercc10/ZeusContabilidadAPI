using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class ImportarArchivoCampo
    {
        public decimal Iden { get; set; }
        public int IdenMaestro { get; set; }
        public string Campo { get; set; } = null!;
        public string Alias { get; set; } = null!;
        public int PosicionCol { get; set; }

        public virtual ImportarArchivo IdenMaestroNavigation { get; set; } = null!;
    }
}
