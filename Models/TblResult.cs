using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class TblResult
{
    public long ResultId { get; set; }

    public long EnrollmentId { get; set; }

    public float TotalScore { get; set; }

    public bool Outcome { get; set; }

    public string? InsertBy { get; set; }

    public DateTime? InsertDate { get; set; }

    public string? UpdateBy { get; set; }

    public DateTime? UpdateDate { get; set; }

    public string? DeleteBy { get; set; }

    public DateTime? DeleteDate { get; set; }

    public virtual TblEnrollment Enrollment { get; set; } = null!;
}
