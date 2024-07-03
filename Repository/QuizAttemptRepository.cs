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
    public class QuizAttemptRepository : QuizAttemptInterface
    {
        private readonly trainingDbContext _dbContext;
        public QuizAttemptRepository(trainingDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<WebAPIResponse> AddQuizAttempt(AddQuizAttempt quizattempt)
        {
            WebAPIResponse _response = new WebAPIResponse();
            try
            {
                var result = _dbContext.AddUpdateQuizAttempt.FromSqlRaw("exec [dbo].[AddUpdateQuizAttempt] @TempAttemptID={0},@TempEnrollmentID={1}, @TempQuizID={2},@TempOptionSelected={3},@TempUser={4}", 0, quizattempt.EnrollmentId, quizattempt.QuizId, quizattempt.OptionSelected, "Elite4").ToList();

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

        public async Task<WebAPIResponse> DeleteQuizAttempt(DeleteQuizAttempt Id)
        {
            WebAPIResponse _response = new WebAPIResponse();
            try
            {
               
                var result = _dbContext.DeleteQuizAttempt.FromSqlRaw("exec [dbo].[DeleteQuizAttempt] @TempAttemptID={0},@TempUser={1}", Id.AttemptId, "Elite4").ToList();
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

        public async Task<WebAPIResponse> GetQuizAttemptById(GetQuizAttemptById Id)
        {
            WebAPIResponse _response = new WebAPIResponse();
            try
            {
                var result = _dbContext.TblQuizAttempts.FromSqlRaw("exec GetQuizAttemptById @TempAttemptID={0}", Id.AttemptId);
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

        public async Task<WebAPIResponse> GetQuizAttemptList()
        {
            WebAPIResponse _response = new WebAPIResponse();
            try
            {
                var result = _dbContext.GetQuizAttempt.FromSqlRaw<GetQuizAttempt>("GetQuizAttemptList").ToList();
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

        public async Task<WebAPIResponse> UpdateQuizAttempt(UpdateQuizAttempt quizattempt)
        {
            WebAPIResponse _response = new WebAPIResponse();
            try
            {
                var result = _dbContext.AddUpdateQuizAttempt.FromSqlRaw("exec [dbo].[AddUpdateQuizAttempt] @TempAttemptID={0},@TempEnrollmentID={1}, @TempQuizID={2},@TempOptionSelected={3}, @TempUser={4}", quizattempt.AttemptId, quizattempt.EnrollmentId, quizattempt.QuizId, quizattempt.OptionSelected, "Elite4").ToList();

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
