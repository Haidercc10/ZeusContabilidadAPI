using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class ZeusExcelSentencia
    {
        public ZeusExcelSentencia()
        {
            ZeusExcelSentenciaCampos = new HashSet<ZeusExcelSentenciaCampo>();
            ZeusExcelSentenciaParametros = new HashSet<ZeusExcelSentenciaParametro>();
        }

        public int Id { get; set; }
        public string? Nombre { get; set; }
        public string? Sentencia { get; set; }
        public bool? IncrementarCol { get; set; }
        public bool? ConservarValores { get; set; }
        public string? NombreHojaGenerar { get; set; }
        public bool? ReemplazaHojaGenerar { get; set; }
        public bool? IncrementarFil { get; set; }

        public virtual ICollection<ZeusExcelSentenciaCampo> ZeusExcelSentenciaCampos { get; set; }
        public virtual ICollection<ZeusExcelSentenciaParametro> ZeusExcelSentenciaParametros { get; set; }
    }
}
