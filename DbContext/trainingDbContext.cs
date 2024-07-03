using System.Collections.Generic;
using BAL.AllHelper;
using Entities.Models;
using Microsoft.EntityFrameworkCore;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static BAL.AllHelper.Hepler;

namespace Entities.Repository;

public partial class trainingDbContext : DbContext
{
    public trainingDbContext()
    {
    }

    public trainingDbContext(DbContextOptions<trainingDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<EmpTbl> EmpTbls { get; set; }

    public virtual DbSet<TblAttachment> TblAttachments { get; set; }
    public virtual DbSet<TblAttachmentExtension> TblAttachmentExtensions { get; set; }

    public virtual DbSet<TblAttachmentType> TblAttachmentTypes { get; set; }


    public virtual DbSet<TblCourse> TblCourses { get; set; }

    public virtual DbSet<TblEnrollment> TblEnrollments { get; set; }

    public virtual DbSet<TblProgress> TblProgresses { get; set; }

    public virtual DbSet<TblProgressStatus> TblProgressStatuses { get; set; }

    public virtual DbSet<TblQuiz> TblQuizzes { get; set; }

    public virtual DbSet<TblQuizAttempt> TblQuizAttempts { get; set; }

    public virtual DbSet<TblResult> TblResults { get; set; }

    public virtual DbSet<TblSubCourse> TblSubCourses { get; set; }


    // Tbl Course
    public virtual DbSet<AllResult> AddUpdateCourse { get; set; }
    public virtual DbSet<AllResult> DeleteCourse { get; set; }
    public virtual DbSet<GetCourse> GetCourse { get; set; }

    public virtual DbSet<GetCourseById> GetCourseById { get; set; }

    // Tbl Subcourse
    public virtual DbSet<AllResult> AddUpdateSubCourse { get; set; }
    public virtual DbSet<AllResult> DeleteSubCourse { get; set; }
    public virtual DbSet<GetSubCourse> GetSubCourse { get; set; }

    public virtual DbSet<GetSubCourseByCourseId> GetSubCourseByCourseId { get; set; }
    public virtual DbSet<GetSubCourseWithCourse> GetSubCourseWithCourse { get; set; }
    public virtual DbSet<GetSubCourseWiseCourse> GetSubCourseWiseCourse { get; set; }
    public virtual DbSet<GetSubCoursedetailwithCourse> GetSubCoursedetailwithCourse { get; set; }


    // Tbl Attachment
    public virtual DbSet<AllResult> AddUpdateAttachment { get; set; }
    public virtual DbSet<AllResult> DeleteAttachment { get; set; }
    public virtual DbSet<GetAttachment> GetAttachment { get; set; }
    public virtual DbSet<GetAttachmentBySubCourseId> GetAttachmentBySubCourseId { get; set; }

    // Tbl Attachment Type Extensions

    public virtual DbSet<GetAttachmentTypeExtensions> GetAttachmentTypeExtension { get; set; }

    // Tbl Quiz
    public virtual DbSet<AllResult> AddUpdateQuiz { get; set; }
    public virtual DbSet<AllResult> DeleteQuiz { get; set; }
    public virtual DbSet<GetQuiz> GetQuiz { get; set; }
    public virtual DbSet<GetQuizBySubCourseId> GetQuizBySubCourseId { get; set; }

    // Tbl Quiz Attempt
    public virtual DbSet<AllResult> AddUpdateQuizAttempt { get; set; }
    public virtual DbSet<AllResult> DeleteQuizAttempt { get; set; }
    public virtual DbSet<GetQuizAttempt> GetQuizAttempt { get; set; }
    public virtual DbSet<GetQuizAttemptById> GetQuizAttemptById { get; set; }

    // Tbl Enrollment
    public virtual DbSet<AllResult> AddUpdateEnrollment { get; set; }
    public virtual DbSet<AllResult> DeleteEnrollment { get; set; }
    public virtual DbSet<GetEnrollment> GetEnrollment { get; set; }
    public virtual DbSet<GetEnrollmentById> GetEnrollmentById { get; set; }
    public virtual DbSet<GetEnrollmentPerCourse> GetEnrollmentPerCourse { get; set; }


    // Tbl Progress

    public virtual DbSet<AllResult> AddUpdateProgress { get; set; }
    public virtual DbSet<AllResult> DeleteProgress { get; set; }
    public virtual DbSet<GetProgress> GetProgress { get; set; }
    public virtual DbSet<GetProgressById> GetProgressById { get; set; }

    // Tbl Progress Status

    public virtual DbSet<AllResult> AddUpdateProgressStatus { get; set; }
    public virtual DbSet<AllResult> DeleteProgressStatus { get; set; }
    public virtual DbSet<GetProgressStatus> GetProgressStatus { get; set; }
    public virtual DbSet<GetProgressStatusById> GetProgressStatusById { get; set; }

    // Tbl Result

    public virtual DbSet<AllResult> AddUpdateResult { get; set; }
    public virtual DbSet<AllResult> DeleteResult { get; set; }
    public virtual DbSet<GetResult> GetResult { get; set; }
    public virtual DbSet<GetResultById> GetResultById { get; set; }

    // Tbl Emp
    public virtual DbSet<AllResult> AddUpdateEmployee { get; set; }
    public virtual DbSet<AllResult> DeleteEmployee { get; set; }
    public virtual DbSet<GetEmployee> GetEmployee { get; set; }
    public virtual DbSet<GetEmployeeById> GetEmployeeById { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=DOLLY\\SQLEXPRESS;Initial Catalog=training;Integrated Security=True;Trust Server Certificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // Tbl Course
        //HasNoKey
        modelBuilder.Entity<AllResult>().HasNoKey().ToView("AddUpdateCourse");
        modelBuilder.Entity<AllResult>().HasNoKey().ToView("DeleteCourse");
        modelBuilder.Entity<GetCourseById>().HasNoKey().ToView("GetCourseById");

        // Tbl Sub Course
        modelBuilder.Entity<AllResult>().HasNoKey().ToView("AddUpdateSubCourse");
        modelBuilder.Entity<AllResult>().HasNoKey().ToView("DeleteSubCourse");
        modelBuilder.Entity<GetSubCourseByCourseId>().HasNoKey().ToView("GetSubCourseByCourseId");
        modelBuilder.Entity<GetSubCourse>().HasNoKey().ToView("GetSubCourse");
        modelBuilder.Entity<GetSubCourseWithCourse>().HasNoKey().ToView("GetSubCourseWithCourse");
        modelBuilder.Entity<GetSubCourseWiseCourse>().HasNoKey().ToView("GetSubCourseWiseCourse");
        modelBuilder.Entity<GetSubCoursedetailwithCourse>().HasNoKey().ToView("GetSubCoursedetailwithCourse");

        // Tbl Attachment
        modelBuilder.Entity<AllResult>().HasNoKey().ToView("AddUpdateAttachment");
        modelBuilder.Entity<AllResult>().HasNoKey().ToView("DeleteAttachment");
        modelBuilder.Entity<GetAttachmentBySubCourseId>().HasNoKey().ToView("GetAttachmentBySubCourseId");
        modelBuilder.Entity<GetAttachment>().HasNoKey().ToView("GetAttachment");

        // Tbl Attachment Type Extensions
        modelBuilder.Entity<GetAttachmentTypeExtensions>().HasNoKey().ToView("GetAttachmentTypeExtensions");
        
        // Tbl Quiz
        modelBuilder.Entity<AllResult>().HasNoKey().ToView("AddUpdateQuiz");
        modelBuilder.Entity<AllResult>().HasNoKey().ToView("DeleteQuiz");
        modelBuilder.Entity<GetQuizBySubCourseId>().HasNoKey().ToView("GetQuizBySubCourseId");
        modelBuilder.Entity<GetQuiz>().HasNoKey().ToView("GetQuiz");
        
        // Tbl Quiz Attempt
        modelBuilder.Entity<AllResult>().HasNoKey().ToView("AddUpdateQuizAttempt");
        modelBuilder.Entity<AllResult>().HasNoKey().ToView("DeleteQuizAttempt");
        modelBuilder.Entity<GetQuizAttemptById>().HasNoKey().ToView("GetQuizAttemptById");
        modelBuilder.Entity<GetQuizAttempt>().HasNoKey().ToView("GetQuizAttempt");

        // Tbl Enrollment
        modelBuilder.Entity<AllResult>().HasNoKey().ToView("AddUpdateEnrollment");
        modelBuilder.Entity<AllResult>().HasNoKey().ToView("DeleteEnrollment");
        modelBuilder.Entity<GetEnrollmentById>().HasNoKey().ToView("GetEnrollmentById");
        modelBuilder.Entity<GetEnrollment>().HasNoKey().ToView("GetEnrollment");
        modelBuilder.Entity<GetEnrollmentPerCourse>().HasNoKey().ToView("GetEnrollmentPerCourse");

        // Tbl Progress
        modelBuilder.Entity<AllResult>().HasNoKey().ToView("AddUpdateProgress");
        modelBuilder.Entity<AllResult>().HasNoKey().ToView("DeleteProgress");
        modelBuilder.Entity<GetProgressById>().HasNoKey().ToView("GetProgressById");
        modelBuilder.Entity<GetProgress>().HasNoKey().ToView("GetProgress");

        // Tbl Progress Status
        modelBuilder.Entity<AllResult>().HasNoKey().ToView("AddUpdateProgressStatus");
        modelBuilder.Entity<AllResult>().HasNoKey().ToView("DeleteProgressStatus");
        modelBuilder.Entity<GetProgressStatusById>().HasNoKey().ToView("GetProgressStatusById");
        modelBuilder.Entity<GetProgressStatus>().HasNoKey().ToView("GetProgressStatus");

        // Tbl Result
        modelBuilder.Entity<AllResult>().HasNoKey().ToView("AddUpdateResult");
        modelBuilder.Entity<AllResult>().HasNoKey().ToView("DeleteResult");
        modelBuilder.Entity<GetResultById>().HasNoKey().ToView("GetResultById");
        modelBuilder.Entity<GetResult>().HasNoKey().ToView("GetResult");

        // Tbl Emp
        modelBuilder.Entity<AllResult>().HasNoKey().ToView("AddUpdateEmployee");
        modelBuilder.Entity<AllResult>().HasNoKey().ToView("DeleteEmployee");
        modelBuilder.Entity<GetEmployeeById>().HasNoKey().ToView("GetEmployeeById");
        modelBuilder.Entity<GetEmployee>().HasNoKey().ToView("GetEmployee");


        modelBuilder.Entity<EmpTbl>(entity =>
        {
            entity.HasKey(e => e.EmpId).HasName("EmpTbl_pk");

            entity.ToTable("EmpTbl");

            entity.Property(e => e.EmpId).HasColumnName("EmpID");
            entity.Property(e => e.Contact)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DeleteBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DeleteDate).HasColumnType("datetime");
            entity.Property(e => e.Email)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.FirstName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.HireDate).HasColumnType("datetime");
            entity.Property(e => e.InsertBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.InsertDate).HasColumnType("datetime");
            entity.Property(e => e.JobTitle)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.LastName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.StartDate).HasColumnType("datetime");
            entity.Property(e => e.Status)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.TerminationDate).HasColumnType("datetime");
            entity.Property(e => e.UpdateBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.UpdateDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<TblAttachment>(entity =>
        {
            entity.HasKey(e => e.AttachmentId).HasName("tblAttachment_pk");

            entity.ToTable("tblAttachment");

            entity.Property(e => e.AttachmentId).HasColumnName("AttachmentID");
            entity.Property(e => e.AttachmentType)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.AttachmentDuration)
            .HasMaxLength(50)
            .IsUnicode(false);
            entity.Property(e => e.DeleteBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DeleteDate).HasColumnType("datetime");
            entity.Property(e => e.Description).IsUnicode(false);
            entity.Property(e => e.FileName).IsUnicode(false);
            entity.Property(e => e.FilePath).IsUnicode(false);
            entity.Property(e => e.InsertBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.InsertDate).HasColumnType("datetime");
            entity.Property(e => e.SubCourseId).HasColumnName("SubCourseID");
            entity.Property(e => e.UpdateBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.UpdateDate).HasColumnType("datetime");

            entity.HasOne(d => d.SubCourse).WithMany(p => p.TblAttachments)
                .HasForeignKey(d => d.SubCourseId)
                .HasConstraintName("tblAttachment_tblSubCourse");
        });

        modelBuilder.Entity<TblAttachmentExtension>(entity =>
        {
            entity.HasKey(e => e.ExtId).HasName("tblAttachmentExtensions_pk");

            entity.HasOne(d => d.AttachmentType).WithMany(p => p.TblAttachmentExtensions).HasConstraintName("fk_AttachmentType");
        });

        modelBuilder.Entity<TblAttachmentType>(entity =>
        {
            entity.HasKey(e => e.AttachmentTypeId).HasName("tblAttachmentType_pk");
        });

        OnModelCreatingPartial(modelBuilder);

        modelBuilder.Entity<TblCourse>(entity =>
        {
            entity.HasKey(e => e.CourseId).HasName("tblCourse_pk");

            entity.ToTable("tblCourse");

            entity.Property(e => e.CourseId).HasColumnName("CourseID");
            entity.Property(e => e.CourseName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.CourseDescription).IsUnicode(false);
            entity.Property(e => e.DeleteBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DeleteDate).HasColumnType("datetime");
            entity.Property(e => e.InsertBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.InsertDate).HasColumnType("datetime");
            entity.Property(e => e.UpdateBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.UpdateDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<TblEnrollment>(entity =>
        {
            entity.HasKey(e => e.EnrollmentId).HasName("tblEnrollment_pk");

            entity.ToTable("tblEnrollment");

            entity.Property(e => e.EnrollmentId).HasColumnName("EnrollmentID");
            entity.Property(e => e.DeleteBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DeleteDate).HasColumnType("datetime");
            entity.Property(e => e.EmpId).HasColumnName("EmpID");
            entity.Property(e => e.EnrollmentDate).HasColumnType("datetime");
            entity.Property(e => e.InsertBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.InsertDate).HasColumnType("datetime");
            entity.Property(e => e.SubCourseId).HasColumnName("SubCourseID");
            entity.Property(e => e.UpdateBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.UpdateDate).HasColumnType("datetime");

            entity.HasOne(d => d.Emp).WithMany(p => p.TblEnrollments)
                .HasForeignKey(d => d.EmpId)
                .HasConstraintName("tblEnrollment_EmpTbl");

            entity.HasOne(d => d.SubCourse).WithMany(p => p.TblEnrollments)
                .HasForeignKey(d => d.SubCourseId)
                .HasConstraintName("tblEnrollment_tblSubCourse");
        });

        modelBuilder.Entity<TblProgress>(entity =>
        {
            entity.HasKey(e => e.ProgressId).HasName("tblProgress_pk");

            entity.ToTable("tblProgress");

            entity.Property(e => e.ProgressId).HasColumnName("ProgressID");
            entity.Property(e => e.DeleteBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DeleteDate).HasColumnType("datetime");
            entity.Property(e => e.EnrollmentId).HasColumnName("EnrollmentID");
            entity.Property(e => e.InsertBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.InsertDate).HasColumnType("datetime");
            entity.Property(e => e.UpdateBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.UpdateDate).HasColumnType("datetime");

            entity.HasOne(d => d.Enrollment).WithMany(p => p.TblProgresses)
                .HasForeignKey(d => d.EnrollmentId)
                .HasConstraintName("tblProgress_tblEnrollment");
        });

        modelBuilder.Entity<TblProgressStatus>(entity =>
        {
            entity.HasKey(e => e.ProgressStatusId).HasName("tblProgressStatus_pk");

            entity.ToTable("tblProgressStatus");

            entity.Property(e => e.ProgressStatusId).HasColumnName("ProgressStatusID");
            entity.Property(e => e.AttachmentId).HasColumnName("AttachmentID");
            entity.Property(e => e.DeleteBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DeleteDate).HasColumnType("datetime");
            entity.Property(e => e.EnrollmentId).HasColumnName("EnrollmentID");
            entity.Property(e => e.InsertBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.InsertDate).HasColumnType("datetime");
            entity.Property(e => e.UpdateBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.UpdateDate).HasColumnType("datetime");

            entity.HasOne(d => d.Attachment).WithMany(p => p.TblProgressStatuses)
                .HasForeignKey(d => d.AttachmentId)
                .HasConstraintName("tblProgressStatus_tblAttachment");

            entity.HasOne(d => d.Enrollment).WithMany(p => p.TblProgressStatuses)
                .HasForeignKey(d => d.EnrollmentId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("tblProgressStatus_tblEnrollment");
        });

        modelBuilder.Entity<TblQuiz>(entity =>
        {
            entity.HasKey(e => e.QuizId).HasName("tblQuiz_pk");

            entity.ToTable("tblQuiz");

            entity.Property(e => e.QuizId).HasColumnName("QuizID");
            entity.Property(e => e.CorrectAns)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.DeleteBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DeleteDate).HasColumnType("datetime");
            entity.Property(e => e.InsertBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.InsertDate).HasColumnType("datetime");
            entity.Property(e => e.OptionA).IsUnicode(false);
            entity.Property(e => e.OptionB).IsUnicode(false);
            entity.Property(e => e.OptionC).IsUnicode(false);
            entity.Property(e => e.OptionD).IsUnicode(false);
            entity.Property(e => e.Questions).IsUnicode(false);
            entity.Property(e => e.SubCourseId).HasColumnName("SubCourseID");
            entity.Property(e => e.UpdateBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.UpdateDate).HasColumnType("datetime");

            entity.HasOne(d => d.SubCourse).WithMany(p => p.TblQuizzes)
                .HasForeignKey(d => d.SubCourseId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("tblQuiz_tblSubCourse");
        });

        modelBuilder.Entity<TblQuizAttempt>(entity =>
        {
            entity.HasKey(e => e.AttemptId).HasName("tblQuizAttempt_pk");

            entity.ToTable("tblQuizAttempt");

            entity.Property(e => e.AttemptId).HasColumnName("AttemptID");
            entity.Property(e => e.DeleteBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DeleteDate).HasColumnType("datetime");
            entity.Property(e => e.EnrollmentId).HasColumnName("EnrollmentID");
            entity.Property(e => e.InsertBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.InsertDate).HasColumnType("datetime");
            entity.Property(e => e.OptionSelected)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.QuizId).HasColumnName("QuizID");
            entity.Property(e => e.UpdateBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.UpdateDate).HasColumnType("datetime");

            entity.HasOne(d => d.Enrollment).WithMany(p => p.TblQuizAttempts)
                .HasForeignKey(d => d.EnrollmentId)
                .HasConstraintName("tblQuizAttempt_tblEnrollment");

            entity.HasOne(d => d.Quiz).WithMany(p => p.TblQuizAttempts)
                .HasForeignKey(d => d.QuizId)
                .HasConstraintName("tblQuizAttempt_tblQuiz");
        });

        modelBuilder.Entity<TblResult>(entity =>
        {
            entity.HasKey(e => e.ResultId).HasName("tblResult_pk");

            entity.ToTable("tblResult");

            entity.Property(e => e.ResultId).HasColumnName("ResultID");
            entity.Property(e => e.DeleteBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DeleteDate).HasColumnType("datetime");
            entity.Property(e => e.EnrollmentId).HasColumnName("EnrollmentID");
            entity.Property(e => e.InsertBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.InsertDate).HasColumnType("datetime");
            entity.Property(e => e.UpdateBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.UpdateDate).HasColumnType("datetime");

            entity.HasOne(d => d.Enrollment).WithMany(p => p.TblResults)
                .HasForeignKey(d => d.EnrollmentId)
                .HasConstraintName("tblResult_tblEnrollment");
        });

        modelBuilder.Entity<TblSubCourse>(entity =>
        {
            entity.HasKey(e => e.SubCourseId).HasName("tblSubCourse_pk");

            entity.ToTable("tblSubCourse");

            entity.Property(e => e.SubCourseId).HasColumnName("SubCourseID");
            entity.Property(e => e.CourseId).HasColumnName("CourseID");
            entity.Property(e => e.DeleteBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DeleteDate).HasColumnType("datetime");
            entity.Property(e => e.Description).IsUnicode(false);
            entity.Property(e => e.Duration)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.InsertBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.InsertDate).HasColumnType("datetime");
            entity.Property(e => e.SubCourseName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Type)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.UpdateBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.UpdateDate).HasColumnType("datetime");

            entity.HasOne(d => d.Course).WithMany(p => p.TblSubCourses)
                .HasForeignKey(d => d.CourseId)
                .HasConstraintName("tblSubCourse_tblCourse");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
