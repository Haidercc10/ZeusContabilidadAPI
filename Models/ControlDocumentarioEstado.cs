using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class ControlDocumentarioEstado
    {
        public ControlDocumentarioEstado()
        {
            ControlDocumentarioEstadosAsignacions = new HashSet<ControlDocumentarioEstadosAsignacion>();
            ControlDocumentarioRecepcionDocumentos = new HashSet<ControlDocumentarioRecepcionDocumento>();
        }

        public decimal Iden { get; set; }
        public string Codigo { get; set; } = null!;
        public string Descripcion { get; set; } = null!;
        public bool Deshabilitado { get; set; }
        public string? Ubicacion { get; set; }

        public virtual ICollection<ControlDocumentarioEstadosAsignacion> ControlDocumentarioEstadosAsignacions { get; set; }
        public virtual ICollection<ControlDocumentarioRecepcionDocumento> ControlDocumentarioRecepcionDocumentos { get; set; }
    }
}
