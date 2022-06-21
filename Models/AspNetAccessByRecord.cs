using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class AspNetAccessByRecord
    {
        public AspNetAccessByRecord()
        {
            AspNetAccessByRecordPrivigeles = new HashSet<AspNetAccessByRecordPrivigele>();
        }

        public int Id { get; set; }
        public string IdRole { get; set; } = null!;
        public int IdMasterEntity { get; set; }
        public bool OnlyOwnRecords { get; set; }
        public bool ByCondition { get; set; }
        public int? IdField { get; set; }
        public string? Operator { get; set; }
        public string? Value { get; set; }

        public virtual AppEntity IdMasterEntityNavigation { get; set; } = null!;
        public virtual ICollection<AspNetAccessByRecordPrivigele> AspNetAccessByRecordPrivigeles { get; set; }
    }
}
