using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class TblProgressStatus
{
    public long ProgressStatusId { get; set; }

    public long EnrollmentId { get; set; }

    public long AttachmentId { get; set; }

    public bool ProgressStatus { get; set; }

    public string? InsertBy { get; set; }

    public DateTime? InsertDate { get; set; }

    public string? UpdateBy { get; set; }

    public DateTime? UpdateDate { get; set; }

    public string? DeleteBy { get; set; }

    public DateTime? DeleteDate { get; set; }

    public virtual TblAttachment Attachment { get; set; } = null!;

    public virtual TblEnrollment Enrollment { get; set; } = null!;
}
