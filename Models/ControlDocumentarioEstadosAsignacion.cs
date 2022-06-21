using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class ControlDocumentarioEstadosAsignacion
    {
        public decimal Iden { get; set; }
        public decimal IdMenu { get; set; }
        public decimal Estado { get; set; }
        public decimal Orden { get; set; }

        public virtual ControlDocumentarioEstado EstadoNavigation { get; set; } = null!;
        public virtual ControlDocumentarioMenu IdMenuNavigation { get; set; } = null!;
    }
}
