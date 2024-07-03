using BAL.AllHelper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static BAL.AllHelper.Hepler;

namespace DAL.Interface
{
    public interface ResultInterface
    {
        public Task<WebAPIResponse> GetResultList();
        public Task<WebAPIResponse> GetResultById(GetResultById Id);
        public Task<WebAPIResponse> AddResult(AddResult results);
        public Task<WebAPIResponse> UpdateResult(UpdateResult results);
        public Task<WebAPIResponse> DeleteResult(DeleteResult Id);
    }
}
