using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class TblQuiz
{
    public long QuizId { get; set; }

    public long SubCourseId { get; set; }

    public string Questions { get; set; } = null!;

    public string OptionA { get; set; } = null!;

    public string OptionB { get; set; } = null!;

    public string OptionC { get; set; } = null!;

    public string OptionD { get; set; } = null!;

    public string CorrectAns { get; set; } = null!;

    public string? InsertBy { get; set; }

    public DateTime? InsertDate { get; set; }

    public string? UpdateBy { get; set; }

    public DateTime? UpdateDate { get; set; }

    public string? DeleteBy { get; set; }

    public DateTime? DeleteDate { get; set; }

    public virtual TblSubCourse SubCourse { get; set; } = null!;

    public virtual ICollection<TblQuizAttempt> TblQuizAttempts { get; set; } = new List<TblQuizAttempt>();
}
