using System;
using System.Collections.Generic;

namespace FCIT.BITF24A.Web.DB_Models;

public partial class User
{
    public long Id { get; set; }

    public string FullName { get; set; }

    public string Username { get; set; }

    public string Email { get; set; }

    public string Password { get; set; }

    public string CreatedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public string ModifiedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }
}
