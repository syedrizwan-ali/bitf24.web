using System;
using System.Collections.Generic;

namespace FCIT.BITF24A.Web.DB_Models;

public partial class UserRole
{
    public long Id { get; set; }

    public long UserId { get; set; }

    public long RoleId { get; set; }
}
