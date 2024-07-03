using BAL.AllHelper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static BAL.AllHelper.Hepler;

namespace DAL.Interface
{
    public interface QuizInterface
    {
        public Task<WebAPIResponse> GetQuizList();
        public Task<WebAPIResponse> GetQuizBySubCourseId(GetQuizBySubCourseId Id);
        public Task<WebAPIResponse> AddQuiz(AddQuiz quiz);//, Question question);
       // public Task<WebAPIResponse> Question();
        public Task<WebAPIResponse> UpdateQuiz(UpdateQuiz quiz);
        public Task<WebAPIResponse> DeleteQuiz(DeleteQuiz Id);
    }
}
