using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class AppVariablesValue
    {
        public int Id { get; set; }
        public int IdVariable { get; set; }
        public int? IdEntity { get; set; }
        public string? MasterRecordCode { get; set; }
        public string? ValueVarchar { get; set; }
        public decimal? ValueNumeric { get; set; }
        public int? ValueInt { get; set; }
        public DateTime? ValueDateTime { get; set; }
        public bool ValueBit { get; set; }
        public DateTime CreationDate { get; set; }
        public string IdUserCreator { get; set; } = null!;
        public DateTime LastUpdate { get; set; }
        public string IdUserLastupdate { get; set; } = null!;
    }
}
