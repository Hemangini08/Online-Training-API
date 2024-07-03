using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class TblCourse
{
    public long CourseId { get; set; }

    public string CourseName { get; set; } = null!;
    public string CourseDescription { get; set; }

    public string? InsertBy { get; set; }

    public DateTime? InsertDate { get; set; }

    public string? UpdateBy { get; set; }

    public DateTime? UpdateDate { get; set; }

    public string? DeleteBy { get; set; }

    public DateTime? DeleteDate { get; set; }

    public virtual ICollection<TblSubCourse> TblSubCourses { get; set; } = new List<TblSubCourse>();
}
