using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Table("tblAttachmentType")]
public partial class TblAttachmentType
{
    [Key]
    [Column("AttachmentTypeID")]
    public long AttachmentTypeId { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string AttachmentType { get; set; } = null!;

    [InverseProperty("AttachmentType")]
    public virtual ICollection<TblAttachmentExtension> TblAttachmentExtensions { get; set; } = new List<TblAttachmentExtension>();
}
