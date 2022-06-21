using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class Tipodcto
    {
        public Tipodcto()
        {
            Fuentes = new HashSet<Fuente>();
            MpgDocumentos = new HashSet<MpgDocumento>();
            UsuariosModificaFechas = new HashSet<UsuariosModificaFecha>();
        }

        public string Idtipdoc { get; set; } = null!;
        public string Destipdoc { get; set; } = null!;
        public int ModificaFecha { get; set; }
        public string FechaDefecto { get; set; } = null!;
        public int Deshabilitado { get; set; }
        public bool PermitirCorreccionDctos { get; set; }
        public byte[] VersionDeLaFila { get; set; } = null!;
        public int IdenTipodctos { get; set; }

        public virtual ICollection<Fuente> Fuentes { get; set; }
        public virtual ICollection<MpgDocumento> MpgDocumentos { get; set; }
        public virtual ICollection<UsuariosModificaFecha> UsuariosModificaFechas { get; set; }
    }
}
