using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class ContingenciasFuente
    {
        public int Id { get; set; }
        public string? Contingencia { get; set; }
        public string FuenteSis { get; set; } = null!;
        public string SerieSis { get; set; } = null!;
        public string FuenteCon { get; set; } = null!;
        public string SerieCon { get; set; } = null!;

        public virtual Contingencia? ContingenciaNavigation { get; set; }
    }
}
