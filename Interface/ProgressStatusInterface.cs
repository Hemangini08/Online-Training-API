using BAL.AllHelper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static BAL.AllHelper.Hepler;

namespace DAL.Interface
{
    public interface ProgressStatusInterface
    {
        public Task<WebAPIResponse> GetProgressStatusList();
        public Task<WebAPIResponse> GetProgressStatusById(GetProgressStatusById Id);
        public Task<WebAPIResponse> AddProgressStatus(AddProgressStatus progressstatus);
        public Task<WebAPIResponse> UpdateProgressStatus(UpdateProgressStatus progressstatus);
        public Task<WebAPIResponse> DeleteProgressStatus(DeleteProgressStatus Id);

    }
}
