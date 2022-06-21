using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class ZeusFwUploadIndexLog
    {
        public int IdUpload { get; set; }
        public int IdEmail { get; set; }
        public string? DsTitle { get; set; }
        public string DsFullPath { get; set; } = null!;
        public DateTime? DtUpdated { get; set; }
        public int? IdUpdated { get; set; }
        public DateTime? DtCreation { get; set; }
        public string? DsFilename { get; set; }
        public int? InDeleteFile { get; set; }
        public int IdenZeusfwUploadindexLog { get; set; }
    }
}
