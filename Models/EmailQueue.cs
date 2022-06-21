using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class EmailQueue
    {
        public int IdEmail { get; set; }
        public string DsToName { get; set; } = null!;
        public string DsToEmail { get; set; } = null!;
        public string? DsFromName { get; set; }
        public string? DsFromEmail { get; set; }
        public string? DsCcName { get; set; }
        public string? DsCcEmail { get; set; }
        public string? DsBccName { get; set; }
        public string? DsBccEmail { get; set; }
        public string? DsSubject { get; set; }
        public string? Message { get; set; }
        public string? DsBody { get; set; }
        public string? DsBody2 { get; set; }
        public string? DsBody3 { get; set; }
        public string? DsBody4 { get; set; }
        public bool? InHtml { get; set; }
        public byte AmSentTimes { get; set; }
        public byte? AmDeliveryTimes { get; set; }
        public DateTime? DtNextDelivery { get; set; }
        public string? CdSection { get; set; }
        public string? CdEmailbody { get; set; }
        public int? IdEmailtype { get; set; }
        public DateTime DtUpdated { get; set; }
        public int? IdUpdated { get; set; }
    }
}
