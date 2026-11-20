using System;
using System.Collections.Generic;

namespace FCIT.BITF24A.Web.OrmModels;

public partial class Student
{
    public long Id { get; set; }

    public string Name { get; set; }

    public string RollNumber { get; set; }

    public DateTime CreatedOn { get; set; }
}
