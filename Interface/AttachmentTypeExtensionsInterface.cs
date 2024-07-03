using BAL.AllHelper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interface
{
    public interface AttachmentTypeExtensionsInterface
    {
        public Task<WebAPIResponse> GetAttachmentTypeExtensionsList();
    }
}
