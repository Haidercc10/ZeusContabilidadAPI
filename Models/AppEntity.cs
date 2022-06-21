using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class AppEntity
    {
        public AppEntity()
        {
            AppEntitiesVariables = new HashSet<AppEntitiesVariable>();
            AspNetAccessByRecords = new HashSet<AspNetAccessByRecord>();
        }

        public int Id { get; set; }
        public int IdEntityType { get; set; }
        public string? CodeRecord { get; set; }
        public string? Name { get; set; }
        public string? MasterDescription { get; set; }
        public string? MasterTable { get; set; }
        public string? FieldSearch { get; set; }

        public virtual ICollection<AppEntitiesVariable> AppEntitiesVariables { get; set; }
        public virtual ICollection<AspNetAccessByRecord> AspNetAccessByRecords { get; set; }
    }
}
