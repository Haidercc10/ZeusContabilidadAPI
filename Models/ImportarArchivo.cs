using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class ImportarArchivo
    {
        public ImportarArchivo()
        {
            ImportarArchivoCampos = new HashSet<ImportarArchivoCampo>();
        }

        public int Iden { get; set; }
        public string Maestro { get; set; } = null!;
        public string Tabla { get; set; } = null!;
        public string Separador { get; set; } = null!;
        public string Sp { get; set; } = null!;
        public string SpExportar { get; set; } = null!;
        public int TipoReg { get; set; }
        public int ColArchivo { get; set; }
        public int ConsultarColumnas { get; set; }
        public int IdenImportararchivo { get; set; }

        public virtual ICollection<ImportarArchivoCampo> ImportarArchivoCampos { get; set; }
    }
}
