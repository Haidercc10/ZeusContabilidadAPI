using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class SysEntidade
    {
        public SysEntidade()
        {
            ArchivosAdjuntosMaestros = new HashSet<ArchivosAdjuntosMaestro>();
        }

        public int Id { get; set; }
        public string DsNombre { get; set; } = null!;
        public string DsDescripcion { get; set; } = null!;
        public int IdenSysEntidades { get; set; }

        public virtual ICollection<ArchivosAdjuntosMaestro> ArchivosAdjuntosMaestros { get; set; }
    }
}
