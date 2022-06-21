using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class ZeusFwBody
    {
        public ZeusFwBody()
        {
            ZeusFwEmailqueues = new HashSet<ZeusFwEmailqueue>();
        }

        public int IdBody { get; set; }
        public string? CdEmailTo { get; set; }
        public string? CdEmailBody { get; set; }
        public string? DsBody { get; set; }
        public string? DsBodyEn { get; set; }
        public string? DsBccEmail { get; set; }
        public string? DsCcEmail { get; set; }
        public string? DsSubject { get; set; }
        public string? DsSubjectEn { get; set; }
        public string? DsUrlTemplate { get; set; }
        public DateTime? DtCreated { get; set; }
        public DateTime? DtUpdated { get; set; }
        public int? IdUpdated { get; set; }
        public int? AmDeliveryTimes { get; set; }
        public string? DsToEmail { get; set; }
        public string? DsToName { get; set; }
        public int IdenZeusfwBody { get; set; }

        public virtual ICollection<ZeusFwEmailqueue> ZeusFwEmailqueues { get; set; }
    }
}
