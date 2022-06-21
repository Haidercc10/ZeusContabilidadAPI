using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class ZeusFwEmailqueue
    {
        public int IdEmail { get; set; }
        public string DsToName { get; set; } = null!;
        public string DsToEmail { get; set; } = null!;
        public string? DsCcEmail { get; set; }
        public string? DsBccEmail { get; set; }
        public string? DsIdiom { get; set; }
        public string DsSubject { get; set; } = null!;
        public string DsBody { get; set; } = null!;
        public int? AmSentTimes { get; set; }
        public string? IdEntity { get; set; }
        public int? IdBody { get; set; }
        public DateTime? DtNextDelivery { get; set; }
        public DateTime? DtCreated { get; set; }
        public DateTime? DtUpdated { get; set; }
        public int? InProcess { get; set; }
        public int? InAttachament { get; set; }
        public int IdEmailConfig { get; set; }
        public int? InEmailLog { get; set; }
        public string? DsMessagefail { get; set; }
        public int? InHtmlBody { get; set; }

        public virtual ZeusFwBody? IdBodyNavigation { get; set; }
        public virtual ZeusFwEmailConfig IdEmailConfigNavigation { get; set; } = null!;
    }
}
