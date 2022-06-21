using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class ArchivoFisico
    {
        public ArchivoFisico()
        {
            ArchivoFisicoDocumentos = new HashSet<ArchivoFisicoDocumento>();
            ArchivoFisicoDocumentosLogAfactualNavigations = new HashSet<ArchivoFisicoDocumentosLog>();
            ArchivoFisicoDocumentosLogAfanteriorNavigations = new HashSet<ArchivoFisicoDocumentosLog>();
        }

        public string CodiArchivoFisico { get; set; } = null!;
        public string DescArchivoFisico { get; set; } = null!;
        public byte NiveArchivoFisico { get; set; }
        public string DepeArchivoFisico { get; set; } = null!;
        public DateTime? FecarchivoFisico { get; set; }
        public int? NcdcarchivoFisico { get; set; }
        public string? TipoArchivoFisico { get; set; }
        public int Deshabilitado { get; set; }
        public int IdenArchivofisico { get; set; }

        public virtual ICollection<ArchivoFisicoDocumento> ArchivoFisicoDocumentos { get; set; }
        public virtual ICollection<ArchivoFisicoDocumentosLog> ArchivoFisicoDocumentosLogAfactualNavigations { get; set; }
        public virtual ICollection<ArchivoFisicoDocumentosLog> ArchivoFisicoDocumentosLogAfanteriorNavigations { get; set; }
    }
}
