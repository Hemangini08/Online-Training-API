using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class TblAttachment
{
    public long AttachmentId { get; set; }

    public long SubCourseId { get; set; }

    public string AttachmentDuration { get; set; }

    public string? Description { get; set; }

    public string FileName { get; set; } = null!;

    public string FilePath { get; set; } = null!;

    public string AttachmentType { get; set; } = null!;

    public string? InsertBy { get; set; }

    public DateTime? InsertDate { get; set; }

    public string? UpdateBy { get; set; }

    public DateTime? UpdateDate { get; set; }

    public string? DeleteBy { get; set; }

    public DateTime? DeleteDate { get; set; }

    public virtual TblSubCourse SubCourse { get; set; } = null!;

    public virtual ICollection<TblProgressStatus> TblProgressStatuses { get; set; } = new List<TblProgressStatus>();
}
