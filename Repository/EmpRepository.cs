using BAL.AllHelper;
using DAL.Interface;
using Entities.Repository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static BAL.AllHelper.Hepler;

namespace DAL.Repository
{
    public class EmpRepository : IEmp
    {
        private readonly trainingDbContext _dbContext;
        public EmpRepository(trainingDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<WebAPIResponse> AddEmployee(Hepler.AddEmployee emp)
        {
            WebAPIResponse _response = new WebAPIResponse();
            try
            {
                var result = _dbContext.AddUpdateEmployee.FromSqlRaw("exec [dbo].[AddUpdateEmployee] @TempEmpID={0},@TempFirstName={1}, @TempLastName={2},@TempJobTitle={3},@TempStartDate={4},@TempHireDate={5},@TempTerminationDate={6},@TempStatus={7},@TempEmail={8},@TempContact={9},@TempUser={10}", 0, emp.FirstName, emp.LastName,emp.JobTtitle,emp.StartDate,emp.HireDate,emp.TerminationDate,emp.Status,emp.Email,emp.Contact, "Elite4").ToList();

                if (result != null)
                {
                    _response.Success = true;
                    _response.Data = result;
                }
                else
                {
                    _response.Success = false;
                    _response.Message = "Data Not Found";
                }
            }
            catch (Exception ex)
            {
                //_response.Success = false;
                //_response.Message = "Something Went Wrong";
                throw;
            }
            return await Task.FromResult(_response);
        }

        public async Task<WebAPIResponse> DeleteEmployee(Hepler.DeleteEmployee Id)
        {
            WebAPIResponse _response = new WebAPIResponse();
            try
            {
                //List<DeleteQuiz> quiz = new List<DeleteQuiz>();
                var result = _dbContext.DeleteEmployee.FromSqlRaw("exec [dbo].[Deleteemp] @EmpID={0}, @TempUser={1}", Id.EmpId, "Elite4").ToList();
                if (result != null)
                {
                    _response.Success = true;
                    _response.Data = result;
                }
                else
                {
                    _response.Success = false;
                    _response.Message = "Data Not Found";
                }

            }
            catch (Exception ex)
            {
                _response.Success = false;
                _response.Message = "Something Went Wrong";
            }
            return await Task.FromResult(_response);
        }

        public async Task<WebAPIResponse> GetEmployeeById(Hepler.GetEmployeeById Id)
        {
            WebAPIResponse _response = new WebAPIResponse();
            try
            {
                var result = _dbContext.EmpTbls.FromSqlRaw("exec GetEmpId @EmpID={0}", Id.EmpId);
                if (result != null)
                {
                    _response.Success = true;
                    _response.Data = result;
                }
                else
                {
                    _response.Success = false;
                    _response.Message = "Data Not Found";
                }
            }
            catch (Exception ex)
            {
                _response.Success = false;
                _response.Message = "Something Went Wrong";
            }
            return await Task.FromResult(_response);
        }

        public async Task<WebAPIResponse> GetEmployeeList()
        {
            WebAPIResponse _response = new WebAPIResponse();
            try
            {
                var result = _dbContext.GetEmployee.FromSqlRaw<GetEmployee>("GetempList").ToList();
                if (result != null)
                {
                    _response.Success = true;
                    _response.Data = result;
                }
                else
                {
                    _response.Success = false;
                    _response.Message = "Data Not Found";
                }
            }
            catch (Exception ex)
            {
                //_response.Success = false;
                //_response.Message = "Something Went Wrong";
                throw;
            }
            return await Task.FromResult(_response);
        }

        public async Task<WebAPIResponse> UpdateEmployee(Hepler.UpdateEmployee emp)
        {
            WebAPIResponse _response = new WebAPIResponse();
            try
            {
                var result = _dbContext.AddUpdateEmployee.FromSqlRaw("exec [dbo].[AddUpdateEmployee] @TempEmpID={0},@TempFirstName={1}, @TempLastName={2},@TempJobTitle={3},@TempStartDate={4},@TempHireDate={5},@TempTerminationDate={6},@TempStatus={7},@TempEmail={8},@TempContact={9},@TempUser={10}", emp.EmpId, emp.FirstName, emp.LastName, emp.JobTtitle, emp.StartDate, emp.HireDate, emp.TerminationDate, emp.Status, emp.Email, emp.Contact, "Elite4").ToList();

                if (result != null)
                {
                    _response.Success = true;
                    _response.Data = result;
                }
                else
                {
                    _response.Success = false;
                    _response.Message = "Data Not Found";
                }
            }
            catch (Exception ex)
            {
                _response.Success = false;
                _response.Message = "Something Went Wrong";

            }
            return await Task.FromResult(_response);
        }
    }
}
