using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class Banco
    {
        public Banco()
        {
            Ger14generals = new HashSet<Ger14general>();
            GerBancoBbvaperus = new HashSet<GerBancoBbvaperu>();
            GerBancoPopularDominicanoBancos = new HashSet<GerBancoPopularDominicanoBanco>();
            GerBanescoRepDominicanaBancos = new HashSet<GerBanescoRepDominicanaBanco>();
            GerBcoSudamerisGenerals = new HashSet<GerBcoSudamerisGeneral>();
            GerCreditoPerus = new HashSet<GerCreditoPeru>();
            GerDavivienda = new HashSet<GerDaviviendum>();
            ImpExtractosDefinicions = new HashSet<ImpExtractosDefinicion>();
            Maeconts = new HashSet<Maecont>();
            MfEscRefbancaria = new HashSet<MfEscRefbancarium>();
        }

        public string Idbanco { get; set; } = null!;
        public string Nombanco { get; set; } = null!;
        public decimal Maxregegreso { get; set; }
        public string Moneda { get; set; } = null!;
        public int Deshabilitado { get; set; }
        public string CodCompensacion { get; set; } = null!;
        public byte[] VersionDeLaFila { get; set; } = null!;
        public int IdenBancos { get; set; }

        public virtual GerenciaAchpanamaBanco GerenciaAchpanamaBanco { get; set; } = null!;
        public virtual ICollection<Ger14general> Ger14generals { get; set; }
        public virtual ICollection<GerBancoBbvaperu> GerBancoBbvaperus { get; set; }
        public virtual ICollection<GerBancoPopularDominicanoBanco> GerBancoPopularDominicanoBancos { get; set; }
        public virtual ICollection<GerBanescoRepDominicanaBanco> GerBanescoRepDominicanaBancos { get; set; }
        public virtual ICollection<GerBcoSudamerisGeneral> GerBcoSudamerisGenerals { get; set; }
        public virtual ICollection<GerCreditoPeru> GerCreditoPerus { get; set; }
        public virtual ICollection<GerDaviviendum> GerDavivienda { get; set; }
        public virtual ICollection<ImpExtractosDefinicion> ImpExtractosDefinicions { get; set; }
        public virtual ICollection<Maecont> Maeconts { get; set; }
        public virtual ICollection<MfEscRefbancarium> MfEscRefbancaria { get; set; }
    }
}
