using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class TblQuizAttempt
{
    public long AttemptId { get; set; }

    public long EnrollmentId { get; set; }

    public long QuizId { get; set; }

    public string OptionSelected { get; set; } = null!;

    public string? InsertBy { get; set; }

    public DateTime? InsertDate { get; set; }

    public string? UpdateBy { get; set; }

    public DateTime? UpdateDate { get; set; }

    public string? DeleteBy { get; set; }

    public DateTime? DeleteDate { get; set; }

    public virtual TblEnrollment Enrollment { get; set; } = null!;

    public virtual TblQuiz Quiz { get; set; } = null!;
}
