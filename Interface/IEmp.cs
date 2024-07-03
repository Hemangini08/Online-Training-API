using BAL.AllHelper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static BAL.AllHelper.Hepler;

namespace DAL.Interface
{
    public interface IEmp
    {
        public Task<WebAPIResponse> GetEmployeeList();
        public Task<WebAPIResponse> GetEmployeeById(GetEmployeeById Id);
        public Task<WebAPIResponse> AddEmployee(AddEmployee emp);
        public Task<WebAPIResponse> UpdateEmployee(UpdateEmployee emp);
        public Task<WebAPIResponse> DeleteEmployee(DeleteEmployee Id);
    }
}
