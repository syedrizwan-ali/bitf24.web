using System;
using System.Collections.Generic;

namespace FCIT.BITF24A.Web.DB_Models;

public partial class Role
{
    public long Id { get; set; }

    public string Name { get; set; }

    public string Code { get; set; }

    public string CreatedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public string ModifiedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }
}
