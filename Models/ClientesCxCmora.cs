using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class ClientesCxCmora
    {
        public string Cliente { get; set; } = null!;
        public string CxC { get; set; } = null!;
        public int IdenClientesCxcmora { get; set; }

        public virtual Cliente ClienteNavigation { get; set; } = null!;
        public virtual Maecont CxCNavigation { get; set; } = null!;
    }
}
