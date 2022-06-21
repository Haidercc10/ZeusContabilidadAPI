using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class ZeusExcelSqlWQuery
    {
        public ZeusExcelSqlWQuery()
        {
            ZeusExcelSqlWAccesoQueries = new HashSet<ZeusExcelSqlWAccesoQuery>();
            ZeusExcelSqlWCondiciones = new HashSet<ZeusExcelSqlWCondicione>();
            ZeusExcelSqlWCriterios = new HashSet<ZeusExcelSqlWCriterio>();
        }

        public int Id { get; set; }
        public string? Descripcion { get; set; }
        public bool Avanzado { get; set; }
        public string? QueryAvanzado { get; set; }
        public bool Publica { get; set; }
        public DateTime FechaCreacion { get; set; }
        public DateTime FechaModificacion { get; set; }
        public string? UsuarioModifico { get; set; }
        public int? TopRegistros { get; set; }

        public virtual ICollection<ZeusExcelSqlWAccesoQuery> ZeusExcelSqlWAccesoQueries { get; set; }
        public virtual ICollection<ZeusExcelSqlWCondicione> ZeusExcelSqlWCondiciones { get; set; }
        public virtual ICollection<ZeusExcelSqlWCriterio> ZeusExcelSqlWCriterios { get; set; }
    }
}
