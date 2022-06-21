using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class RevelacionesMese
    {
        public string Anomes { get; set; } = null!;
        public string OpenMes { get; set; } = null!;
        public int IdenRevelacionesmeses { get; set; }

        public virtual Mese AnomesNavigation { get; set; } = null!;
    }
}
