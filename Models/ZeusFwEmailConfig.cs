using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class ZeusFwEmailConfig
    {
        public ZeusFwEmailConfig()
        {
            ZeusFwEmailqueues = new HashSet<ZeusFwEmailqueue>();
        }

        public int IdEmailConfig { get; set; }
        public int AmPort { get; set; }
        public string DsHost { get; set; } = null!;
        public string? DsUserName { get; set; }
        public string DsUser { get; set; } = null!;
        public string DsPassword { get; set; } = null!;
        public int? InSsl { get; set; }
        public int? InBodyHtml { get; set; }
        public DateTime DtCreation { get; set; }
        public int? AmNotificationoptions { get; set; }
        public int? AmPriority { get; set; }
        public int? AmSendTimes { get; set; }
        public int InDefault { get; set; }
        public string DsEmailCc { get; set; } = null!;

        public virtual ICollection<ZeusFwEmailqueue> ZeusFwEmailqueues { get; set; }
    }
}
