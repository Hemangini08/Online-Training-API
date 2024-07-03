using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Table("tblAttachmentExtensions")]
public partial class TblAttachmentExtension
{
    [Key]
    [Column("ExtID")]
    public long ExtId { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string Extension { get; set; } = null!;

    [Column("AttachmentTypeID")]
    public long AttachmentTypeId { get; set; }

    [ForeignKey("AttachmentTypeId")]
    [InverseProperty("TblAttachmentExtensions")]
    public virtual TblAttachmentType AttachmentType { get; set; } = null!;
}
