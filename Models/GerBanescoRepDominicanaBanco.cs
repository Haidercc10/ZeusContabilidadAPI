using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class GerBanescoRepDominicanaBanco
    {
        public int Id { get; set; }
        public string Codigo { get; set; } = null!;
        public string Nombre { get; set; } = null!;
        public string? DigVerificacion { get; set; }
        public string? BancoCont { get; set; }

        public virtual Banco? BancoContNavigation { get; set; }
    }
}
