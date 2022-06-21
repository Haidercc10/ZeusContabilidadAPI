using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class ControlDocumentarioAgrupacion
    {
        public int Id { get; set; }
        public int Consecutivo { get; set; }
        public int IdenRecepcionDocumento { get; set; }
        public DateTime? Fecha { get; set; }
    }
}
