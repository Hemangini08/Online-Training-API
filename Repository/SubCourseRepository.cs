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
    public class SubCourseRepository : SubCourseInterface
    {
        private readonly trainingDbContext _dbContext;
        public SubCourseRepository(trainingDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<WebAPIResponse> AddSubCourse(AddSubCourse subcourse)
        {
            WebAPIResponse _response = new WebAPIResponse();
            try
            {
                var result = _dbContext.AddUpdateSubCourse.FromSqlRaw("exec [dbo].[AddUpdateSubCourse] @TempSubCourseID={0}, @TempCourseID={1}, @TempSubCourseName={2},@TempDescription={3}, @TempType={4}, @TempUser={5}", 0, subcourse.CourseId,
                  subcourse.SubCourseName, subcourse.Description, subcourse.Type,  "Elite4").ToList();

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

        public async Task<WebAPIResponse> DeleteSubCourse(DeleteSubCourse Id)
        {
            WebAPIResponse _response = new WebAPIResponse();
            try
            {
                
                var result = _dbContext.DeleteSubCourse.FromSqlRaw("exec [dbo].[DeleteSubCourse] @TempSubCourseId={0}, @TempUser={1}", Id.SubCourseId, "Elite4").ToList();
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

        public async Task<WebAPIResponse> GetSubCourseByCourseId(GetSubCourseByCourseId Id)
        {
            WebAPIResponse _response = new WebAPIResponse();
            try
            {
                var result = _dbContext.TblSubCourses.FromSqlRaw("exec GetSubCourseByCourseId @TempCourseId={0}", Id.CourseId);
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

        public async Task<WebAPIResponse> GetSubCoursedetailwithCourse(GetSubCoursedetailwithCourse Id)
        {
            WebAPIResponse _response = new WebAPIResponse();
            try
            {
                var result = _dbContext.GetSubCourseWiseCourse.FromSqlRaw<GetSubCourseWiseCourse>("exec GetSubCourse @TempCourseId={0},@TempSubCourseId={1}", Id.CourseId,Id.SubCourseId).ToList();
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

        public async Task<WebAPIResponse> GetSubCourseList()
        {
            WebAPIResponse _response = new WebAPIResponse();
            try
            {
                var result = _dbContext.GetSubCourse.FromSqlRaw<GetSubCourse>("exec GetSubCourseList").ToList();
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

        public async Task<WebAPIResponse> GetSubCourseWithCourse(GetSubCourseWithCourse Id)
        {
            WebAPIResponse _response = new WebAPIResponse();
            try
            {
                var result = _dbContext.GetSubCourseWiseCourse.FromSqlRaw<GetSubCourseWiseCourse>("exec GetCourseWithSubCourses @TempCourseId={0}", Id.CourseId).ToList();
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

        public async Task<WebAPIResponse> UpdateSubCourse(UpdateSubCourse subcourse)
        {
            WebAPIResponse _response = new WebAPIResponse();
            try
            {
                var result = _dbContext.AddUpdateSubCourse.FromSqlRaw("exec [dbo].[AddUpdateSubCourse] @TempSubCourseID={0}, @TempCourseID={1}, @TempSubCourseName={2},@TempDescription={3}, @TempType={4},  @TempUser={5}", subcourse.SubCourseId, subcourse.CourseId,
                         subcourse.SubCourseName, subcourse.Description, subcourse.Type,"Elite4").ToList();
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
                throw ex;
            }
            return await Task.FromResult(_response);
        }
    }
}
