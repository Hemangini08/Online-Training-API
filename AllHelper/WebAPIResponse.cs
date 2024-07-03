using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAL.AllHelper
{
    public class WebAPIResponse
    {
        public bool Success { get; set; }
        public string Message { get; set; }
        public object Data { get; set; }

        public object TotalRecords { get; set; }

        public string Error { get; set; }

        public WebAPIResponse()
        {
            Success = false;
            Data = "";
            Error = "";
            Message = "";
        }
    }
}
