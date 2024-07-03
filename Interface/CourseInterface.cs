using BAL.AllHelper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static BAL.AllHelper.Hepler;

namespace DAL.Interface
{
    public interface CourseInterface
    {
        public Task<WebAPIResponse> GetCourseList();
        public Task<WebAPIResponse> GetCourseById(GetCourseById Id);
        public Task<WebAPIResponse> AddCourse(AddCourse course);
        public Task<WebAPIResponse> UpdateCourse(UpdateCourse course);
        public Task<WebAPIResponse> DeleteCourse(DeleteCourse Id);
    }
}



