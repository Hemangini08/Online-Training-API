using BAL.AllHelper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static BAL.AllHelper.Hepler;

namespace DAL.Interface
{
    public interface ProgressInterface
    {
        public Task<WebAPIResponse> GetProgressList();
        public Task<WebAPIResponse> GetProgressById(GetProgressById Id);
        public Task<WebAPIResponse> AddProgress(AddProgress progress);
        public Task<WebAPIResponse> UpdateProgress(UpdateProgress progress);
        public Task<WebAPIResponse> DeleteProgress(DeleteProgress Id);
    
}
}
