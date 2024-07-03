using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace BAL.AllHelper
{
    public class Hepler
    { 
        // Tbl Course
        [Keyless]
        public class AddCourse
        {
            //public long CourseId { get; set; }
            public string CourseName { get; set; }
            public string CourseDescription { get; set; }
            //public string InsertBy = "Elite4";
        }
        [Keyless]
        public class UpdateCourse
        {
            public long CourseId { get; set; }
            public string CourseName { get; set; }
            public string CourseDescription { get; set; }
            //public string UpdateBy = "Elite4";
        }
        [Keyless]
        public class GetCourse
        {
            public long CourseId { get; set; }
            public string CourseName { get; set; }
            public string CourseDescription { get; set; }
        }
        [Keyless]
        public class DeleteCourse
        {
            public long CourseId { get; set; }
            //public string DeleteBy = "Elite4";
        }
        [Keyless]
        public class GetCourseById
        {
            public long CourseId { get; set; }
        }

        //Tbl Subcourse
        [Keyless]
        public class AddSubCourse
        {
            //public long SubCourseId { get; set; }
            public long CourseId { get; set; }
            public string SubCourseName { get; set; }
            public string Description { get; set; }
            public string Type { get; set; }
            //public string Duration { get; set; }
            //public string InsertBy = "Elite4";
        }
        [Keyless]
        public class UpdateSubCourse
        {
            public long SubCourseId { get; set; }
            public long CourseId { get; set; }
            public string SubCourseName { get; set; }
            public string Description { get; set; }
            public string Type { get; set; }
           // public string Duration { get; set; }
            //public string UpdateBy = "Elite4";
        }
        [Keyless]
        public class GetSubCourse
        {
            public long SubCourseId { get; set; }
            public long CourseId { get; set; }
            public string SubCourseName { get; set; }
            public string Description { get; set; }
            public string Type { get; set; }
            //public string Duration { get; set; }
            public string CourseName { get; set; }
        }
        [Keyless]
        public class DeleteSubCourse
        {
            public long SubCourseId { get; set; }
            //public string DeleteBy = "Elite4";
        }
        [Keyless]
        public class GetSubCourseByCourseId
        {
            public long CourseId { get; set;}
        }
        [Keyless]
        public class GetSubCourseWithCourse
        {
            public long CourseId { get; set; }
        }
        [Keyless]
        public class GetSubCourseWiseCourse
        {
            public long CourseId { get; set; }
            public string CourseName { get; set; }
            public string CourseDescription { get; set; }
            public long SubCourseId { get; set; }
            public string SubCourseName { get; set;}

            public string Description { get; set; }
        }
        [Keyless]
        public class GetSubCoursedetailwithCourse
        {
            public long CourseId { get; set; }
            public long SubCourseId { get; set; }
        }

        //Tbl Attachment
        [Keyless]
        public class Attachment
        {
            public long attachmentId { get; set; }
            public long subCourseId { get; set; }
            public string timeToComplete { get; set; }
            public string description { get; set; }
            public string fileName { get; set; }
            public string filePath = "";
            public string attachmentType { get; set; }
            [NotMapped]
            public IFormFile file { get; set; }
            //public string InsertBy = "Elite4";
        }

        [Keyless]
        public class AddAttachment
        {
            [NotMapped]
            public List<Attachment> AttachmentList { get; set; }
        }

        //[Keyless]
        //public class Attachment
        //{
        //    public long attachmentId { get; set; }
        //    public long subCourseId { get; set; }
        //    public string attachmentDuration { get; set; }
        //    public string description { get; set; }
        //    public string fileName { get; set; }
        //    public string filePath = "";
        //    public string attachmentType { get; set;
        //    [NotMapped]
        //    public  ImageURL {  get; set; }

        //}

            [Keyless]
        public class UpdateAttachment
        {
            public long AttachmentId { get; set; }
            public long SubCourseId { get; set; }
            public string AttachmentDuration { get; set; }
            public string Description { get; set; }
            public string FileName { get; set; }
            public string FilePath { get; set; }
            public string AttachmentType { get; set; }
            //public string UpdateBy = "Elite4";
        }
        [Keyless]
        public class GetAttachment
        {
            public long AttachmentId { get; set; }
            public long SubCourseId { get; set; }
            //public string AttachmentDuration { get; set; }
            public string AttachmentFiles { get; set; }
            public string Description { get; set; }
            public string FileName { get; set; }
            public string FilePath { get; set; }
            public string AttachmentType { get; set; }
           // public string SubCourseName { get; set; }
        }
        [Keyless]
        public class DeleteAttachment
        {
            public long AttachmentId { get; set; }
            //public string DeleteBy = "Elite4";
        }
        [Keyless]
        public class GetAttachmentBySubCourseId
        {
            public long SubCourseId { get; set; }
        }

        // Tbl Attachment Type Extension

        [Keyless]
        public class GetAttachmentTypeExtensions
        {
            public long ExtId { get; set; } 
            public string Extension { get; set; }
            public long AttachmentTypeId { get; set; }
            public string AttachmentType { get; set; }
        }

        // Tbl Quiz
        [Keyless]
        public class AddQuiz
        {
            [NotMapped]
           public List<Question> QuestionList { get; set; }
        }

        [Keyless]
        public class Question
        {
            public long quizId { get; set; }
            public long subCourseId { get; set; }
            public string question { get; set; }
            public string optA { get; set; }
            public string optB { get; set; }
            public string optC { get; set; }
            public string optD { get; set; }
            public string correctOpt { get; set; }
        }
        [Keyless]
        public class UpdateQuiz
        {
            public long QuizId { get; set; }
            public long SubCourseId { get; set; }
            public string Questions { get; set; }
            public string OptionA { get; set; }
            public string OptionB { get; set; }
            public string OptionC { get; set; }
            public string OptionD { get; set; }
            public string CorrectAns { get; set; }
            //public string UpdateBy = "Elite4";
        }
        [Keyless]
        public class GetQuiz
        {
            public long QuizId { get; set; }
            public long SubCourseId { get; set; }
            public string Questions { get; set; }
            public string OptionA { get; set; }
            public string OptionB { get; set; }
            public string OptionC { get; set; }
            public string OptionD { get; set; }
            public string CorrectAns { get; set; }
            public string SubCourseName { get; set; }
        }
        [Keyless]
        public class DeleteQuiz
        {
            public long QuizId { get; set; }
            //public string DeleteBy = "Elite4";
        }
        [Keyless]
        public class GetQuizBySubCourseId
        {
            public long SubCourseId { get; set; }

        }

        // Tbl QuizAttempt
        [Keyless]
        public class AddQuizAttempt
        {
            //public long AttemptId { get; set; }
            public long EnrollmentId { get; set; }
            public long QuizId { get; set; }
            public string OptionSelected { get; set; }
            //public string InsertBy = "Elite4";
        }
        [Keyless]
        public class UpdateQuizAttempt
        {
            public long AttemptId { get; set; }
            public long EnrollmentId { get; set; }
            public long QuizId { get; set; }
            public string OptionSelected { get; set; }
            //public string UpdateBy = "Elite4";
        }
        [Keyless]
        public class GetQuizAttempt
        {
            public long AttemptId { get; set; }
            public long EnrollmentId { get; set; }
            public long QuizId { get; set; }
            public string OptionSelected { get; set; }
        }
        [Keyless]
        public class DeleteQuizAttempt
        {
            public long AttemptId { get; set; }
            //public string DeleteBy = "Elite4";
        }
        [Keyless]
        public class GetQuizAttemptById
        {
            public long AttemptId { get; set; }
        }

        // Tbl Enrollment
        [Keyless]
        public class AddEnrollment
        {
            //public long EnrollmentId { get; set; }
            public long EmpId { get; set; }
            public long SubCourseId { get; set; }
            //public DateTime EnrollmentDate { get; set; }
            //public string InsertBy = "Elite4";
        }
        [Keyless]
        public class UpdateEnrollment
        {
            public long EnrollmentId { get; set; }
            public long EmpId { get; set; }
            public long SubCourseId { get; set; }
            //public DateTime EnrollmentDate { get; set; }
           // public string UpdateBy = "Elite4";
        }
        [Keyless]
        public class GetEnrollment
        {
            public long EnrollmentId { get; set; }
            public long EmpId { get; set; }
            public long SubCourseId { get; set; }
            public DateTime EnrollmentDate { get; set; }

            public string SubCourseName { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
        }
        [Keyless]
        public class DeleteEnrollment
        {
            public long EnrollmentId { get; set; }
            //public string DeleteBy = "Elite4";
        }
        [Keyless]
        public class GetEnrollmentById
        {
            public long EnrollmentId { get; set; }
        }
        [Keyless]
        public class GetEnrollmentPerCourse
        {
            public int enrollmentCount { get; set; }
            public long subCourseId { get; set; }
            public string subCourseName { get; set; }
            public long courseId { get; set; }
            public string courseName { get; set; }
        }

        // Tbl Progress
        [Keyless]
        public class AddProgress
        {
            //public long ProgressId { get; set; }

            public long EnrollmentId { get; set; }

            public float ProgressPercentage { get; set; }

            //public string? InsertBy = "Elite4";
        }
        [Keyless]
        public class UpdateProgress
        {
            public long ProgressId { get; set; }

            public long EnrollmentId { get; set; }

            public float ProgressPercentage { get; set; }

            //public string? UpdateBy = "Elite4";
        }
        [Keyless]
        public class DeleteProgress
        {
            public long ProgressId { get; set; }
            //public string? DeleteBy = "Elite4";
        }
        [Keyless]
        public class GetProgress
        {
            public long ProgressId { get; set; }

            public long EnrollmentId { get; set; }

            public float ProgressPercentage { get; set; }
        }
        [Keyless]
        public class GetProgressById
        {
            public long ProgressId { get; set;}
        }

        // Tbl Progress Status
        [Keyless]
        public class AddProgressStatus
        {
            //public long ProgressStatusId { get; set; }

            public long EnrollmentId { get; set; }

            public long AttachmentId { get; set; }

            public bool ProgressStatus { get; set; }

            //public string? InsertBy = "Elite4";
        }
        [Keyless]
        public class UpdateProgressStatus
        {
            public long ProgressStatusId { get; set; }

            public long EnrollmentId { get; set; }

            public long AttachmentId { get; set; }

            public bool ProgressStatus { get; set; }

            //public string? UpdateBy = "Elite4";
        }
        [Keyless]
        public class GetProgressStatus
        {
            public long ProgressStatusId { get; set; }

            public long EnrollmentId { get; set; }

            public long AttachmentId { get; set; }

            public bool ProgressStatus { get; set; }

            public string? FileName { get; set; }
        }
        [Keyless]
        public class DeleteProgressStatus
        {
            public long ProgressStatusId { get; set; }

            //public string? DeleteBy = "Elite4";
        }
        [Keyless]
        public class GetProgressStatusById
        {
            public long ProgressStatusId { get; set; }
        }

        // Tbl Result
        [Keyless]
        public class AddResult
        {
            //public long ResultId { get; set; }
            public long EnrollmentId { get; set; }
            public bool TotalScore { get; set; }
            public bool Outcome { get; set; }
            //public string InsertBy = "Elite4";
        }
        [Keyless]
        public class UpdateResult
        {
            public long ResultId { get; set; }
            public long EnrollmentId { get; set; }
            public bool TotalScore { get; set; }
            public bool Outcome { get; set; }
            //public string UpdateBy = "Elite4";
        }
        [Keyless]
        public class GetResult
        {
            public long ResultId { get; set; }
            public long EnrollmentId { get; set; }
            public bool TotalScore { get; set; }
            public bool Outcome { get; set; }
        }
        [Keyless]
        public class DeleteResult
        {
            public long ResultId { get; set;}
            //public string DeleteBy = "Elite4";
        }
        [Keyless]
        public class GetResultById
        {
            public long ResultId { get; set; }
        }
        //Emp
        [Keyless]
        public class AddEmployee
        {
            //public long EmpId { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string JobTtitle { get; set; }
            public DateTime StartDate { get; set; } 
            public DateTime HireDate { get; set; }
            public DateTime TerminationDate { get; set; }
            public string Status { get; set; }
            public string Email { get; set; }
            public string Contact {  get; set; }    
           
            //public string InsertBy = "Elite4";
        }
        [Keyless]
        public class UpdateEmployee
        {
            public long EmpId { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string JobTtitle { get; set; }
            public DateTime StartDate { get; set; }
            public DateTime HireDate { get; set; }
            public DateTime TerminationDate { get; set; }
            public string Status { get; set; }
            public string Email { get; set; }
            public string Contact { get; set; }
           
            //public string UpdateBy = "Elite4";
        }
        [Keyless]
        public class GetEmployee
        {
            public long EmpId { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string Email { get; set; }
            public string Contact { get; set; }
           
        }
        [Keyless]
        public class DeleteEmployee
        {
            public long EmpId { get; set; }
            //public string DeleteBy = "Elite4";
        }
        [Keyless]
        public class GetEmployeeById
        {
            public long EmpId { get; set; }   
        }
    }
}
