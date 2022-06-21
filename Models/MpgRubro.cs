using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class MpgRubro
    {
        public MpgRubro()
        {
            MpgApropiacions = new HashSet<MpgApropiacion>();
            MpgItems = new HashSet<MpgItem>();
        }

        public string Rubro { get; set; } = null!;
        public string Descripcion { get; set; } = null!;
        public string Dependencia { get; set; } = null!;
        public int Nivel { get; set; }
        public string Tipo { get; set; } = null!;
        public int Ncd { get; set; }
        public string? Recurso { get; set; }
        public string? CuentaPapropiacion { get; set; }
        public string? CuentaCapropiacion { get; set; }
        public string? CuentaCdp { get; set; }
        public string? CuentaRegistro { get; set; }
        public string? CuentaObligacion { get; set; }
        public string? CuentaCierreP { get; set; }
        public string? CuentaPcierre { get; set; }
        public string? CuentaCcierre { get; set; }
        public string? CuentaPreserva { get; set; }
        public string? CuentaCreserva { get; set; }
        public string? CuentaOreserva { get; set; }
        public string? CuentaCierreReserva { get; set; }
        public string? CuentaPcxP { get; set; }
        public string? CuentaCcxP { get; set; }
        public string? CuentaCierreCxP { get; set; }
        public string Clasificacion { get; set; } = null!;
        public int IdenMpgRubro { get; set; }

        public virtual Maecont? CuentaCapropiacionNavigation { get; set; }
        public virtual Maecont? CuentaCcierreNavigation { get; set; }
        public virtual Maecont? CuentaCcxPNavigation { get; set; }
        public virtual Maecont? CuentaCdpNavigation { get; set; }
        public virtual Maecont? CuentaCierreCxPNavigation { get; set; }
        public virtual Maecont? CuentaCierrePNavigation { get; set; }
        public virtual Maecont? CuentaCierreReservaNavigation { get; set; }
        public virtual Maecont? CuentaCreservaNavigation { get; set; }
        public virtual Maecont? CuentaObligacionNavigation { get; set; }
        public virtual Maecont? CuentaOreservaNavigation { get; set; }
        public virtual Maecont? CuentaPapropiacionNavigation { get; set; }
        public virtual Maecont? CuentaPcierreNavigation { get; set; }
        public virtual Maecont? CuentaPcxPNavigation { get; set; }
        public virtual Maecont? CuentaPreservaNavigation { get; set; }
        public virtual Maecont? CuentaRegistroNavigation { get; set; }
        public virtual MpgRecurso? RecursoNavigation { get; set; }
        public virtual ICollection<MpgApropiacion> MpgApropiacions { get; set; }
        public virtual ICollection<MpgItem> MpgItems { get; set; }
    }
}
