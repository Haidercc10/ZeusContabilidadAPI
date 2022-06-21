using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class ExcelInfodesignperfil
    {
        public string Idcodigo { get; set; } = null!;
        public int Idperfil { get; set; }
        public int Permiso { get; set; }
        public int IdenExcelInfodesignperfil { get; set; }

        public virtual Infodesign IdcodigoNavigation { get; set; } = null!;
    }
}
