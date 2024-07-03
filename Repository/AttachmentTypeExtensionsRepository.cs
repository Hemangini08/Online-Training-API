using BAL.AllHelper;
using DAL.Interface;
using Entities.Models;
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
    public class AttachmentTypeExtensionsRepository : AttachmentTypeExtensionsInterface
    {
        private readonly trainingDbContext _dbContext;
        public AttachmentTypeExtensionsRepository(trainingDbContext dbContext) {
            _dbContext = dbContext;
        }
        public async Task<WebAPIResponse> GetAttachmentTypeExtensionsList()
        {
            WebAPIResponse _response = new WebAPIResponse();
            try
            {
                var result = _dbContext.GetAttachmentTypeExtension.FromSqlRaw("exec [GetAttachmentTypeExtensions]").ToList();

                if (result != null)
                {
                    _response.Success = true;
                    _response.Data = result;
                }
                else
                {
                    _response.Success = false;
                    _response.Message = "Data Not Found!";
                }
            }
            catch (Exception ex)
            {
                //_response.Success = false;
                //_response.Message = "Something Went Wrong";
                throw ex;

            }
            return await Task.FromResult(_response);
        }
    }
}
