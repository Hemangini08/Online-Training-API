using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class TblSubCourse
{
    public long SubCourseId { get; set; }

    public long CourseId { get; set; }

    public string SubCourseName { get; set; } = null!;

    public string? Description { get; set; }

    public string Type { get; set; } = null!;

    public string? Duration { get; set; }

    public string? InsertBy { get; set; }

    public DateTime? InsertDate { get; set; }

    public string? UpdateBy { get; set; }

    public DateTime? UpdateDate { get; set; }

    public string? DeleteBy { get; set; }

    public DateTime? DeleteDate { get; set; }

    public virtual TblCourse Course { get; set; } = null!;

    public virtual ICollection<TblAttachment> TblAttachments { get; set; } = new List<TblAttachment>();

    public virtual ICollection<TblEnrollment> TblEnrollments { get; set; } = new List<TblEnrollment>();

    public virtual ICollection<TblQuiz> TblQuizzes { get; set; } = new List<TblQuiz>();
}
