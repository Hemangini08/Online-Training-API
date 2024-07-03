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
    public class ProgressStatusRepository : ProgressStatusInterface
    {
        private readonly trainingDbContext _dbContext;
        public ProgressStatusRepository(trainingDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<WebAPIResponse> AddProgressStatus(AddProgressStatus progressstatus)
        {
            WebAPIResponse _response = new WebAPIResponse();
            try
            {
                var result = _dbContext.AddUpdateProgressStatus.FromSqlRaw("exec [dbo].[AddUpdateProgressStatus] @TempProgressStatusID ={0}, @TempEnrollmentID ={1}, @TempAttachmentID ={2}, @TempProgressStatus={3}, @TempUser ={4}", 0, progressstatus.EnrollmentId, progressstatus.AttachmentId, progressstatus.ProgressStatus, "Elite4").ToList();

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

        public async Task<WebAPIResponse> DeleteProgressStatus(DeleteProgressStatus Id)
        {
            WebAPIResponse _response = new WebAPIResponse();
            try
            {
               
                var result = _dbContext.DeleteProgressStatus.FromSqlRaw("exec [dbo].[DeleteProgressStatus] @TempProgressStatusID={0}, @TempUser={1}", Id.ProgressStatusId, "Elite4").ToList();
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

        public async Task<WebAPIResponse> GetProgressStatusById(GetProgressStatusById Id)
        {
            WebAPIResponse _response = new WebAPIResponse();
            try
            {
                var result = _dbContext.TblProgressStatuses.FromSqlRaw("exec GetProgressStatusById @TempProgressStatusID={0}", Id.ProgressStatusId);
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

        public async Task<WebAPIResponse> GetProgressStatusList()
        {
            WebAPIResponse _response = new WebAPIResponse();
            try
            {
                var result = _dbContext.GetProgressStatus.FromSqlRaw<GetProgressStatus>("GetProgressStatusList").ToList();
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

        public async Task<WebAPIResponse> UpdateProgressStatus(UpdateProgressStatus progressstatus)
        {
            WebAPIResponse _response = new WebAPIResponse();
            try
            {
                var result = _dbContext.AddUpdateProgressStatus.FromSqlRaw("exec [dbo].[AddUpdateProgressStatus] @TempProgressStatusID ={0}, @TempEnrollmentID ={1}, @TempAttachmentID ={2}, @TempProgressStatus={3}, @TempUser ={4}", progressstatus.ProgressStatusId, progressstatus.EnrollmentId, progressstatus.AttachmentId, progressstatus.ProgressStatus, "Elite4").ToList();

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
