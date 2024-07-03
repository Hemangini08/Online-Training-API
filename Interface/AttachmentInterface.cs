using BAL.AllHelper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static BAL.AllHelper.Hepler;

namespace DAL.Interface
{
    public interface AttachmentInterface
    {
        public Task<WebAPIResponse> GetAttachmentList();
        public Task<WebAPIResponse> GetAttachmentBySubCourseId(GetAttachmentBySubCourseId Id);
        public Task<WebAPIResponse> AddAttachment(AddAttachment attachment);
        public Task<WebAPIResponse> UpdateAttachment(UpdateAttachment attachment);
        public Task<WebAPIResponse> DeleteAttachment(DeleteAttachment Id);
    }
}
