using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class AspNetAccessByRecordPrivigele
    {
        public int Id { get; set; }
        public int IdAspNetAccessByRecord { get; set; }
        public int IdPrivilege { get; set; }

        public virtual AspNetAccessByRecord IdAspNetAccessByRecordNavigation { get; set; } = null!;
    }
}
