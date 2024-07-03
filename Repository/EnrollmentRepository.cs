using BAL.AllHelper;
using DAL.Interface;
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
    public class EnrollmentRepository : EnrollmentInterface
    {
        private readonly trainingDbContext _dbContext;
        public EnrollmentRepository(trainingDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<WebAPIResponse> AddEnrollment(AddEnrollment enrollment)
        {
            WebAPIResponse _response = new WebAPIResponse();
            try
            {
                var result = _dbContext.AddUpdateEnrollment.FromSqlRaw("exec [dbo].[AddUpdateEnrollment] @TempEnrollmentID={0}, @TempEmpID={1},@TempSubCourseID={2},@TempUser={3}",0, enrollment.EmpId, enrollment.SubCourseId, "Elite4").ToList();
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
                //_response.Success = false;
                //_response.Message = "Something Went Wrong ";
                throw ex;
            }
            return await Task.FromResult(_response);
        }

        public async Task<WebAPIResponse> DeleteEnrollment(DeleteEnrollment Id)
        {
            WebAPIResponse _response = new WebAPIResponse();
            try
            {
               // List<DeleteEnrollment> course = new List<DeleteEnrollment>();
                var result = _dbContext.DeleteEnrollment.FromSqlRaw("exec [dbo].[DeleteEnrollment] @TempEnrollmentID={0},@TempUser={1}", Id.EnrollmentId, "Elite4").ToList();
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

        public async Task<WebAPIResponse> GetEnrollmentById(GetEnrollmentById Id)
        {
            WebAPIResponse _response = new WebAPIResponse();
            try
            {
                var result = _dbContext.TblEnrollments.FromSqlRaw("exec GetEnrollmentById @TempEnrollmentID={0}", Id.EnrollmentId);
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

        public async Task<WebAPIResponse> GetEnrollmentList()
        {
            WebAPIResponse _response = new WebAPIResponse();
            try
            {
                var result = _dbContext.GetEnrollment.FromSqlRaw<GetEnrollment>("exec GetEnrollmentList").ToList();
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

        public async Task<WebAPIResponse> GetEnrollmentPerCourseList()
        {
            WebAPIResponse _response = new WebAPIResponse();
            try
            {
                var result = _dbContext.GetEnrollmentPerCourse.FromSqlRaw<GetEnrollmentPerCourse>("exec GetEnrollmentPerCourse").ToList();
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

        public async  Task<WebAPIResponse> UpdateEnrollment(UpdateEnrollment enrollment)
        {
            WebAPIResponse _response = new WebAPIResponse();
            try
            {
                var result = _dbContext.AddUpdateEnrollment.FromSqlRaw("exec [dbo].[AddUpdateEnrollment] @TempEnrollmentID={0}, @TempEmpID={1},@TempSubCourseID={2},@TempUser={3}", enrollment.EnrollmentId, enrollment.EmpId, enrollment.SubCourseId, "Elite4").ToList();
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
    }
}
