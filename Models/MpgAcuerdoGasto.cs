using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class MpgAcuerdoGasto
    {
        public string AnoMes { get; set; } = null!;
        public string Rubro { get; set; } = null!;
        public string Recurso { get; set; } = null!;
        public decimal ValorInicial { get; set; }
        public decimal Valor { get; set; }
        public decimal Cdp { get; set; }
        public decimal Crp { get; set; }
        public decimal Ocp { get; set; }
        public decimal Entrada { get; set; }
        public decimal Reserva { get; set; }
        public decimal ReservaEntrada { get; set; }
        public decimal Adiciones { get; set; }
        public decimal Disminuciones { get; set; }
        public decimal TrasladosDb { get; set; }
        public decimal TrasladosCr { get; set; }
        public decimal Congelacion { get; set; }
        public string Bu { get; set; } = null!;
        public int IdenMpgAcuerdogasto { get; set; }
    }
}
