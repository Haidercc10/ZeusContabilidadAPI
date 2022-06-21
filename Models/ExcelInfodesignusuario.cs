using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class ExcelInfodesignusuario
    {
        public string Idcodigo { get; set; } = null!;
        public string Idusuario { get; set; } = null!;
        public int Permiso { get; set; }
        public int IdenExcelInfodesignusuario { get; set; }

        public virtual Infodesign IdcodigoNavigation { get; set; } = null!;
        public virtual Usuario1 IdusuarioNavigation { get; set; } = null!;
    }
}
