using BAL.AllHelper;
using DAL.Interface;
using Entities.Models;
using Entities.Repository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static BAL.AllHelper.Hepler;

namespace DAL.Repository
{
    public class CourseRepository : CourseInterface
    {
        private readonly trainingDbContext _dbContext;
        public CourseRepository(trainingDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<WebAPIResponse> AddCourse(AddCourse course)
        {
            WebAPIResponse _response = new WebAPIResponse();
            try
            {
                var result = _dbContext.AddUpdateCourse.FromSqlRaw("exec [dbo].[AddUpdateCourse] @TempCourseID={0}, @TempCourseName={1},@TempCourseDescription={2},@TempUser={3}",
                                                                 0, course.CourseName,course.CourseDescription, "Elite4").ToList();
                if (result != null)
                {
                    _response.Success = true;
                    _response.Data = new { result };
                }
                else
                {
                    _response.Success = false;
                    _response.Message = "Data Not Found!";
                }
            }
            catch (Exception ex)
            {
                _response.Success = false;
                _response.Message = "Something Went Wrong ";
            }
            return await Task.FromResult(_response);
        }

        public async Task<WebAPIResponse> DeleteCourse(DeleteCourse Id)
        {
            WebAPIResponse _response = new WebAPIResponse();
            try
            {
               // List<DeleteCourse> course = new List<DeleteCourse>();
                var result = _dbContext.DeleteCourse.FromSqlRaw("exec [dbo].[DeleteCourse] @TempCourseID={0},@TempUser={1}", Id.CourseId, "Elite4").ToList();
                if (result != null)
                {
                    _response.Success = true;
                    _response.Data = result;
                }
                else
                {
                    _response.Success = false;
                    _response.Message = "Data Not Found";
                }
            }
            catch (Exception ex)
            {
                //_response.Success = false;
                //_response.Message = "Something Went Wrong";
                throw;
            }
            return await Task.FromResult(_response);
        }

        public async Task<WebAPIResponse> GetCourseById(GetCourseById Id)
        {
            WebAPIResponse _response = new WebAPIResponse();
            try
            {
                var result = _dbContext.TblCourses.FromSqlRaw("exec GetCourseById @TempCourseID={0}", Id.CourseId);
                if (result != null)
                {
                    _response.Success = true;
                    _response.Data = result;
                }
                else
                {
                    _response.Success = false;
                    _response.Message = "Data Not Found";
                }
            }
            catch (Exception ex)
            {
                _response.Success = false;
                _response.Message = "Something Went Wrong";
            }
            return await Task.FromResult(_response);
        }
        public async Task<WebAPIResponse> GetCourseList()
        {
            WebAPIResponse _response = new WebAPIResponse();
            try
            {
                var result = _dbContext.TblCourses.FromSqlRaw<TblCourse>("exec GetCourseList").ToList();
                if (result != null)
                {
                    _response.Success = true;
                    _response.Data = result;
                }
                else
                {
                    _response.Success = false;
                    _response.Message = "Data Not Found";
                }
            }
            catch (Exception ex)
            {
                _response.Success = false;
                _response.Message = "Something Went Wrong";
                throw;
            }
            return await Task.FromResult(_response);
        }

        public async Task<WebAPIResponse> UpdateCourse(UpdateCourse course)
        {
            WebAPIResponse _response = new WebAPIResponse();
            try
            {
                var result = _dbContext.AddUpdateCourse.FromSqlRaw("exec [dbo].[AddUpdateCourse] @TempCourseId ={0}, @TempCourseName ={1},@TempCourseDescription={2},@TempUser={3}", course.CourseId, course.CourseName,course.CourseDescription, "Elite4").ToList();

                if (result != null)
                {
                    _response.Success = true;
                    _response.Data = result;
                }
                else
                {
                    _response.Success = false;
                    _response.Message = "Data Not Found";
                }

            }
            catch (Exception ex)
            {
                _response.Success = false;
                _response.Message = "Something Went Wrong";
              
            }
            return await Task.FromResult(_response);
        }
    }
}



