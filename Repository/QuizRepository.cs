using BAL.AllHelper;
using DAL.Interface;
using Entities.Models;
using Entities.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage.Json;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static BAL.AllHelper.Hepler;

namespace DAL.Repository
{
    public class QuizRepository : QuizInterface
    {
        private readonly trainingDbContext _dbContext;
        public QuizRepository(trainingDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<WebAPIResponse> AddQuiz(AddQuiz quiz )
        {
            WebAPIResponse _response = new WebAPIResponse();
            try
            {
                string jsonQuiz = JsonConvert.SerializeObject(quiz.QuestionList);

                    var result = _dbContext.AddUpdateQuiz.FromSqlRaw("exec [dbo].[AddUpdateQuiz] @Json={0},@TempUser={1}",
                                                                                                  jsonQuiz, "Elite4").ToList();

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

        public async Task<WebAPIResponse> DeleteQuiz(DeleteQuiz Id)
        {
            WebAPIResponse _response = new WebAPIResponse();
            try
            {
                List<DeleteQuiz> quiz = new List<DeleteQuiz>();
                var result = _dbContext.DeleteQuiz.FromSqlRaw("exec [dbo].[DeleteQuiz] @TempQuizID={0}, @TempUser={1}", Id.QuizId, "Elite4").ToList();
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

        public async Task<WebAPIResponse> GetQuizBySubCourseId(GetQuizBySubCourseId Id)
        {
            WebAPIResponse _response = new WebAPIResponse();
            try
            {
                var result = _dbContext.TblQuizzes.FromSqlRaw("exec GetQuizById @TempSubCourseID={0}", Id.SubCourseId);
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

        public async Task<WebAPIResponse> GetQuizList()
        {
            WebAPIResponse _response = new WebAPIResponse();
            try
            {
                var result = _dbContext.GetQuiz.FromSqlRaw<GetQuiz>("GetQuizList").ToList();
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

        public async Task<WebAPIResponse> UpdateQuiz(UpdateQuiz quiz)
        {
            WebAPIResponse _response = new WebAPIResponse();
            try
            {
                var result = _dbContext.AddUpdateQuiz.FromSqlRaw("exec [dbo].[AddUpdateQuiz] @TempQuizID={0},@TempSubCourseID={1}, @TempQuestions={2},@TempOptionA={3},@TempOptionB={4},@TempOptionC={5},@TempOptionD={6},@TempCorrectAns={7},@TempUser={8}", quiz.QuizId, quiz.SubCourseId, quiz.Questions, quiz.OptionA, quiz.OptionB, quiz.OptionC, quiz.OptionD, quiz.CorrectAns, "Elite4").ToList();

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
