using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class ZeusExcelInfodesignRemoto
    {
        public int Id { get; set; }
        public string Usuario { get; set; } = null!;
        public string Nombrelibro { get; set; } = null!;
        public string Filedesign { get; set; } = null!;
        public DateTime Fechacreacion { get; set; }
        public DateTime Fechamodificacion { get; set; }
    }
}
