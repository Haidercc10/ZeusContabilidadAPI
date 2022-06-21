using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class MpgRecurso
    {
        public MpgRecurso()
        {
            MpgItems = new HashSet<MpgItem>();
            MpgRubros = new HashSet<MpgRubro>();
        }

        public string Codigo { get; set; } = null!;
        public string Descripcion { get; set; } = null!;
        public int IdenMpgRecurso { get; set; }

        public virtual ICollection<MpgItem> MpgItems { get; set; }
        public virtual ICollection<MpgRubro> MpgRubros { get; set; }
    }
}
