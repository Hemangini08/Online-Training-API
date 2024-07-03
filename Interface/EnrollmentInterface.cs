using BAL.AllHelper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static BAL.AllHelper.Hepler;

namespace DAL.Interface
{
    public interface EnrollmentInterface
    {
        public Task<WebAPIResponse> GetEnrollmentList();
        public Task<WebAPIResponse> GetEnrollmentPerCourseList();
        public Task<WebAPIResponse> GetEnrollmentById(GetEnrollmentById Id);
        public Task<WebAPIResponse> AddEnrollment(AddEnrollment enrollment);
        public Task<WebAPIResponse> UpdateEnrollment(UpdateEnrollment enrollment);
        public Task<WebAPIResponse> DeleteEnrollment(DeleteEnrollment Id);
    }
}
