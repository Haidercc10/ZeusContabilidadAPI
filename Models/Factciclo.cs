using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class Factciclo
    {
        public Factciclo()
        {
            FactciclosFacturados = new HashSet<FactciclosFacturado>();
            FactciclosMesDia = new HashSet<FactciclosMesDium>();
        }

        public decimal Iden { get; set; }
        public string Codigo { get; set; } = null!;
        public string Nombre { get; set; } = null!;
        public string Descripcion { get; set; } = null!;
        public DateTime? FechaInicial { get; set; }
        public DateTime? FechaFinal { get; set; }
        public int Finaliza { get; set; }
        public int TipoPeriodicidad { get; set; }
        public int TipoConfPorDia { get; set; }
        public int TipoConfPorMeses { get; set; }
        public int Dias { get; set; }
        public int Meses { get; set; }
        public int DiaMes { get; set; }
        public int Mes1 { get; set; }
        public int Mes2 { get; set; }
        public int Mes3 { get; set; }
        public int Mes4 { get; set; }
        public int Mes5 { get; set; }
        public int Mes6 { get; set; }
        public int Mes7 { get; set; }
        public int Mes8 { get; set; }
        public int Mes9 { get; set; }
        public int Mes10 { get; set; }
        public int Mes11 { get; set; }
        public int Mes12 { get; set; }
        public int ValidarUltFechaFact { get; set; }
        public string Bu { get; set; } = null!;
        public string Tipo { get; set; } = null!;

        public virtual ICollection<FactciclosFacturado> FactciclosFacturados { get; set; }
        public virtual ICollection<FactciclosMesDium> FactciclosMesDia { get; set; }
    }
}
