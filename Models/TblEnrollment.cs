using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class TblEnrollment
{
    public long EnrollmentId { get; set; }

    public long EmpId { get; set; }

    public long SubCourseId { get; set; }

    public DateTime EnrollmentDate { get; set; }

    public string? InsertBy { get; set; }

    public DateTime? InsertDate { get; set; }

    public string? UpdateBy { get; set; }

    public DateTime? UpdateDate { get; set; }

    public string? DeleteBy { get; set; }

    public DateTime? DeleteDate { get; set; }

    public virtual EmpTbl Emp { get; set; } = null!;

    public virtual TblSubCourse SubCourse { get; set; } = null!;

    public virtual ICollection<TblProgressStatus> TblProgressStatuses { get; set; } = new List<TblProgressStatus>();

    public virtual ICollection<TblProgress> TblProgresses { get; set; } = new List<TblProgress>();

    public virtual ICollection<TblQuizAttempt> TblQuizAttempts { get; set; } = new List<TblQuizAttempt>();

    public virtual ICollection<TblResult> TblResults { get; set; } = new List<TblResult>();
}
