using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class ZiNomIntegraCco
    {
        public int Idcencointerface { get; set; }
        public string Idcenco { get; set; } = null!;
        public int IdenZiNomintegraCco { get; set; }

        public virtual Maecco IdcencoNavigation { get; set; } = null!;
    }
}
