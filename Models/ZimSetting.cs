using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class ZimSetting
    {
        public int Iden { get; set; }
        public bool ZEnabled { get; set; }
        public string Url { get; set; } = null!;
        public string Code { get; set; } = null!;
        public string Realm { get; set; } = null!;
        public string Client { get; set; } = null!;
        public DateTime LastUpdate { get; set; }
        public bool ExportUser { get; set; }
        public int IdenZimSettings { get; set; }
    }
}
