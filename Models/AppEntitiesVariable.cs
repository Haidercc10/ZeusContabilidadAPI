using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class AppEntitiesVariable
    {
        public int Id { get; set; }
        public int IdEntity { get; set; }
        public int IdVariable { get; set; }
        public string? Formula { get; set; }
        public int? OrderEvalFormula { get; set; }
        public string? Conditions { get; set; }
        public bool? IsRequired { get; set; }
        public bool? UniqueValue { get; set; }
        public bool? CompoundValue { get; set; }

        public virtual AppEntity IdEntityNavigation { get; set; } = null!;
    }
}
