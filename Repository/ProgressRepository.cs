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
    public class ProgressRepository: ProgressInterface
    {
        private readonly trainingDbContext _dbContext;
        public ProgressRepository(trainingDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<WebAPIResponse> AddProgress(AddProgress progress)
        {
            WebAPIResponse _response = new WebAPIResponse();
            try
            {
                var result = _dbContext.AddUpdateProgress.FromSqlRaw("exec [dbo].[AddUpdateProgress] @TempProgressID ={0}, @TempEnrollmentID ={1}, @TempProgressPercentage ={2}, @TempUser ={3}", 0, progress.EnrollmentId, progress.ProgressPercentage, "Elite4").ToList();

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

        public async Task<WebAPIResponse> DeleteProgress(DeleteProgress Id)
        {
            WebAPIResponse _response = new WebAPIResponse();
            try
            {
                //List<DeleteQuiz> quiz = new List<DeleteQuiz>();
                var result = _dbContext.DeleteProgress.FromSqlRaw("exec [dbo].[DeleteProgress] @TempProgressID={0}, @TempUser={1}", Id.ProgressId, "Elite4").ToList();
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

        public async Task<WebAPIResponse> GetProgressById(GetProgressById Id)
        {
            WebAPIResponse _response = new WebAPIResponse();
            try
            {
                var result = _dbContext.TblProgresses.FromSqlRaw("exec GetProgressById @TempProgressID={0}", Id.ProgressId);
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

        public async Task<WebAPIResponse> GetProgressList()
        {
            WebAPIResponse _response = new WebAPIResponse();
            try
            {
                var result = _dbContext.GetProgress.FromSqlRaw<GetProgress>("GetProgressList").ToList();
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

        public async Task<WebAPIResponse> UpdateProgress(UpdateProgress progress)
        {
            WebAPIResponse _response = new WebAPIResponse();
            try
            {
                var result = _dbContext.AddUpdateProgress.FromSqlRaw("exec [dbo].[AddUpdateProgress] @TempProgressID ={0}, @TempEnrollmentID ={1}, @TempProgressPercentage ={2}, @TempUser ={3}", progress.ProgressId, progress.EnrollmentId, progress.ProgressPercentage, "Elite4").ToList();

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
