using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class MaeVendeCorreo
    {
        public int Id { get; set; }
        public string Idvende { get; set; } = null!;
        public string DsEmail { get; set; } = null!;

        public virtual Maevende IdvendeNavigation { get; set; } = null!;
    }
}
