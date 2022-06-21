using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class AspNetRolePrivilege
    {
        public int Id { get; set; }
        public string RoleId { get; set; } = null!;
        public int PrivilegeId { get; set; }
    }
}
