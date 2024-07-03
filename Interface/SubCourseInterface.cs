using BAL.AllHelper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static BAL.AllHelper.Hepler;

namespace DAL.Interface
{
    public interface SubCourseInterface
    {
        public Task<WebAPIResponse> GetSubCourseList();
        public Task<WebAPIResponse> GetSubCourseByCourseId(GetSubCourseByCourseId Id);
        public Task<WebAPIResponse> GetSubCoursedetailwithCourse(GetSubCoursedetailwithCourse Id);
        public Task<WebAPIResponse> GetSubCourseWithCourse(GetSubCourseWithCourse Id);
        public Task<WebAPIResponse> AddSubCourse(AddSubCourse subcourse);
        public Task<WebAPIResponse> UpdateSubCourse(UpdateSubCourse subcourse);
        public Task<WebAPIResponse> DeleteSubCourse(DeleteSubCourse Id);
    }
}
