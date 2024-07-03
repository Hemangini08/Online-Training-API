using BAL.AllHelper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static BAL.AllHelper.Hepler;

namespace DAL.Interface
{
    public interface QuizAttemptInterface
    {
        public Task<WebAPIResponse> GetQuizAttemptList();
        public Task<WebAPIResponse> GetQuizAttemptById(GetQuizAttemptById Id);
        public Task<WebAPIResponse> AddQuizAttempt(AddQuizAttempt quizattempt);
        public Task<WebAPIResponse> UpdateQuizAttempt(UpdateQuizAttempt quizattempt);
        public Task<WebAPIResponse> DeleteQuizAttempt(DeleteQuizAttempt Id);
    }
}
