using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class MpgAcuerdoPago
    {
        public string AnoMes { get; set; } = null!;
        public string Rubro { get; set; } = null!;
        public string Recurso { get; set; } = null!;
        public decimal ValorInicial { get; set; }
        public decimal Valor { get; set; }
        public decimal Opago { get; set; }
        public decimal Egreso { get; set; }
        public decimal ReservaOpago { get; set; }
        public decimal ReservaEgreso { get; set; }
        public decimal CxP { get; set; }
        public decimal CxPEgreso { get; set; }
        public decimal Adiciones { get; set; }
        public decimal Disminuciones { get; set; }
        public decimal TrasladosDb { get; set; }
        public decimal TrasladosCr { get; set; }
        public string Bu { get; set; } = null!;
        public int IdenMpgAcuerdopago { get; set; }
    }
}
