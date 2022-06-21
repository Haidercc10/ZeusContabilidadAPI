using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class ZeusExcelSqlWCondicione
    {
        public int Id { get; set; }
        public int SqlWQueryId { get; set; }
        public string ParentesisAb { get; set; } = null!;
        public string AliasCampo { get; set; } = null!;
        public string Operador { get; set; } = null!;
        public string Valor { get; set; } = null!;
        public string ParentesisCe { get; set; } = null!;
        public string? OLogico { get; set; }

        public virtual ZeusExcelSqlWQuery SqlWQuery { get; set; } = null!;
    }
}
