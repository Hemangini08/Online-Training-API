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
    public class ResultRepository:ResultInterface
    {
        private readonly trainingDbContext _dbContext;
        public ResultRepository(trainingDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<WebAPIResponse> AddResult(AddResult results)
        {
            WebAPIResponse _response = new WebAPIResponse();
            try
            {
                var result = _dbContext.AddUpdateResult.FromSqlRaw("exec [dbo].[AddUpdateResult] @TempResultID ={0}, @TempEnrollmentID ={1}, @TempTotalScore ={2}, @TempOutcome={3}, @TempUser ={4}", 0, results.EnrollmentId, results.TotalScore, results.Outcome, "Elite4").ToList();

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

        public async Task<WebAPIResponse> DeleteResult(DeleteResult Id)
        {
            WebAPIResponse _response = new WebAPIResponse();
            try
            {
                
                var result = _dbContext.DeleteResult.FromSqlRaw("exec [dbo].[DeleteResult] @TempResultID={0}, @TempUser={1}", Id.ResultId, "Elite4").ToList();
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

        public async Task<WebAPIResponse> GetResultById(GetResultById Id)
        {
            WebAPIResponse _response = new WebAPIResponse();
            try
            {
                var result = _dbContext.TblResults.FromSqlRaw("exec GetResultById @TempResultID={0}", Id.ResultId);
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

        public async Task<WebAPIResponse> GetResultList()
        {
            WebAPIResponse _response = new WebAPIResponse();
            try
            {
                var result = _dbContext.GetResult.FromSqlRaw<GetResult>("GetResultList").ToList();
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

        public async Task<WebAPIResponse> UpdateResult(UpdateResult results)
        {
            WebAPIResponse _response = new WebAPIResponse();
            try
            {
                var result = _dbContext.AddUpdateResult.FromSqlRaw("exec [dbo].[AddUpdateResult] @TempResultID ={0}, @TempEnrollmentID ={1}, @TempTotalScore ={2}, @TempOutcome={3}, @TempUser ={4}", results.ResultId, results.EnrollmentId, results.TotalScore, results.Outcome, "Elite4").ToList();

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
