using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class ZeusExcelInfodesignPerfil
    {
        public string Idcodigo { get; set; } = null!;
        public string Idperfil { get; set; } = null!;
        public int Permiso { get; set; }

        public virtual ZeusExcelInfodesign IdcodigoNavigation { get; set; } = null!;
    }
}
