using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class EscenariosDocumentosRevertido
    {
        public decimal Iden { get; set; }
        public string Fuente { get; set; } = null!;
        public string Documento { get; set; } = null!;
        public int IdenEscenariosDocumentosRevertidos { get; set; }

        public virtual EscenariosDocumento IdenNavigation { get; set; } = null!;
    }
}
