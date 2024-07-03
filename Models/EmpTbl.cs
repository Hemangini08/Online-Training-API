using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class EmpTbl
{
    public long EmpId { get; set; }

    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public string JobTitle { get; set; } = null!;

    public DateTime? StartDate { get; set; }

    public DateTime HireDate { get; set; }

    public DateTime? TerminationDate { get; set; }

    public string Status { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string Contact { get; set; } = null!;

    public string? InsertBy { get; set; }

    public DateTime? InsertDate { get; set; }

    public string? UpdateBy { get; set; }

    public DateTime? UpdateDate { get; set; }

    public string? DeleteBy { get; set; }

    public DateTime? DeleteDate { get; set; }

    public virtual ICollection<TblEnrollment> TblEnrollments { get; set; } = new List<TblEnrollment>();
}
