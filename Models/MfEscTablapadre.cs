using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class MfEscTablapadre
    {
        public MfEscTablapadre()
        {
            MfEscBienesraices = new HashSet<MfEscBienesraice>();
            MfEscRefbancaria = new HashSet<MfEscRefbancarium>();
            MfEscRefgenerals = new HashSet<MfEscRefgeneral>();
            MfEscVehiculos = new HashSet<MfEscVehiculo>();
        }

        public int IdTablamaestro { get; set; }
        public string Fecha { get; set; } = null!;
        public string? Codzona { get; set; }
        public decimal Valorsolicitado { get; set; }
        public string? CodCodeudor { get; set; }
        public string Fechabalance { get; set; } = null!;
        public string Estado { get; set; } = null!;
        public string? CodUsuario { get; set; }
        public int Estudio { get; set; }
        public string TipoEstudio { get; set; } = null!;
        public string Prestamo { get; set; } = null!;
        public decimal Nestudios { get; set; }
        public int IdenMfEscTablapadre { get; set; }

        public virtual MfDatosusuario? CodUsuarioNavigation { get; set; }
        public virtual Maezona? CodzonaNavigation { get; set; }
        public virtual MfEscActivo MfEscActivo { get; set; } = null!;
        public virtual MfEscEgreso MfEscEgreso { get; set; } = null!;
        public virtual MfEscIngreso MfEscIngreso { get; set; } = null!;
        public virtual MfEscPasivo MfEscPasivo { get; set; } = null!;
        public virtual ICollection<MfEscBienesraice> MfEscBienesraices { get; set; }
        public virtual ICollection<MfEscRefbancarium> MfEscRefbancaria { get; set; }
        public virtual ICollection<MfEscRefgeneral> MfEscRefgenerals { get; set; }
        public virtual ICollection<MfEscVehiculo> MfEscVehiculos { get; set; }
    }
}
