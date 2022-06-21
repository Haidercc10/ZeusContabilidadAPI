using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class AppSearcher
    {
        public AppSearcher()
        {
            AppSearcherFields = new HashSet<AppSearcherField>();
        }

        public int Id { get; set; }
        public string Code { get; set; } = null!;
        public string Name { get; set; } = null!;
        public string SqlSelect { get; set; } = null!;
        public string SqlChoice { get; set; } = null!;
        public int IndexColCode { get; set; }
        public int CurrentPageDefault { get; set; }
        public int RecordsByPageDefault { get; set; }
        public string? ColumnsPercentWidth { get; set; }
        public string? ColumnsShow { get; set; }
        public string? SqlPredicate { get; set; }
        public string? NameColCode { get; set; }
        public string? FieldRelVariablesValue { get; set; }

        public virtual ICollection<AppSearcherField> AppSearcherFields { get; set; }
    }
}
