using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class ControlDocumentarioMenu
    {
        public ControlDocumentarioMenu()
        {
            ControlDocumentarioEstadosAsignacions = new HashSet<ControlDocumentarioEstadosAsignacion>();
        }

        public decimal IdMenu { get; set; }
        public string Nombre { get; set; } = null!;
        public int IdenControldocumentarioMenu { get; set; }

        public virtual ICollection<ControlDocumentarioEstadosAsignacion> ControlDocumentarioEstadosAsignacions { get; set; }
    }
}
