using BAL.AllHelper;
using DAL.Interface;
using Entities.Models;
using Entities.Repository;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using static BAL.AllHelper.Hepler;

namespace DAL.Repository
{
    public class AttachmentRepository : AttachmentInterface
    {
        private readonly trainingDbContext _dbContext;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly IHostingEnvironment _environment;
        private readonly IConfiguration _configuration;
        public AttachmentRepository(trainingDbContext dbContext,  IHttpContextAccessor httpContextAccessor,IConfiguration configuration,IHostingEnvironment environment)
        {
            _dbContext = dbContext;
            _httpContextAccessor = httpContextAccessor;
            _configuration = configuration;
            _environment = environment;
        }

        public async Task<WebAPIResponse> AddAttachment(AddAttachment attachment)
        {
            WebAPIResponse _response = new WebAPIResponse();
            try
            {
                string path = "\\Uploads\\attachment";
                var uploads = Path.Combine(_environment.ContentRootPath, "wwwroot" + path).Replace(" /","\\");

                string jsonAttachment = JsonConvert.SerializeObject(attachment.AttachmentList);

                foreach (var item in attachment.AttachmentList)
                {

                    if (item.file != null)
                    {
                        string fileExtension = Path.GetExtension(item.file.FileName);
                        item.filePath = $"{item.subCourseId}_{item.fileName.Replace(" ", " ")}{fileExtension}";

                        //uploads = Path.Combine(uploads, item.subCourseId.ToString());

                        //if (!Directory.Exists(uploads))
                        //{
                        //    Directory.CreateDirectory(uploads);
                        //}

                        //var filePathOriginal = Path.Combine(uploads, item.filePath);

                        //using (var fileStream = new FileStream(filePathOriginal, FileMode.Create))
                        //{
                        //    await item.file.CopyToAsync(fileStream);
                        //}
                    }
                }
                jsonAttachment = JsonConvert.SerializeObject(attachment.AttachmentList);
                var result = _dbContext.AddUpdateAttachment.FromSqlRaw("exec AddUpdateAttachment @Json={0},@TempUser={1}",
                                                              jsonAttachment, "Elite4").ToList();
                    
                    if (result != null)
                    {

                        if (result[0].Result)
                        {
                            foreach (var item in attachment.AttachmentList)
                            {
                            uploads = Path.Combine(uploads, item.subCourseId.ToString());

                            if (!Directory.Exists(uploads))
                            {
                                Directory.CreateDirectory(uploads);
                            }

                            var filePathOriginal = Path.Combine(uploads, item.filePath);

                            using (var fileStream = new FileStream(filePathOriginal, FileMode.Create))
                            {
                                await item.file.CopyToAsync(fileStream);
                            }
                        }
                    }
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

        public async Task<WebAPIResponse> DeleteAttachment(DeleteAttachment Id)
        {
            WebAPIResponse _response = new WebAPIResponse();
            try
            {
               // List<DeleteAttachment> attachments = new List<DeleteAttachment>();
                var result = _dbContext.DeleteAttachment.FromSqlRaw("exec [dbo].[DeleteAttachment] @TempAttachmentID={0}, @TempUser={1}", Id.AttachmentId, "Elite4").ToList();

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
                _response.Success = false;
                _response.Message = "Something Went Wrong";
            }
            return await Task.FromResult(_response);
        }

        public async Task<WebAPIResponse> GetAttachmentBySubCourseId(GetAttachmentBySubCourseId Id)
        {
            WebAPIResponse _response = new WebAPIResponse();
            try
            {
                var ImageURL = "";
                ImageURL = _httpContextAccessor.HttpContext.Request.Scheme + "://" + _httpContextAccessor.HttpContext.Request.Host + string.Format("/Uploads/attachment", "NK");
                var result = _dbContext.GetAttachment.FromSqlRaw("exec GetAttachmentById @TempSubCourseID={0}, @ImageURL={1}", Id.SubCourseId, ImageURL); ;

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
                _response.Success = false;
                _response.Message = "Something Went Wrong";
            }
            return await Task.FromResult(_response);
        }

        public async Task<WebAPIResponse> GetAttachmentList()
        {
            WebAPIResponse _response = new WebAPIResponse();
            try
            {
                var result = _dbContext.GetAttachment.FromSqlRaw<GetAttachment>("GetAttachmentList").ToList();

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
                _response.Success = false;
                _response.Message = "Something Went Wrong";
                
            }
            return await Task.FromResult(_response);

        }

        public async Task<WebAPIResponse> UpdateAttachment(UpdateAttachment attachment)
        {
            WebAPIResponse _response = new WebAPIResponse();
            try
            {
                string path = "\\Uploads\\attachment";
               // var uploads = Path.Combine(_environment.ContentRootPath, "wwwroot" + path).Replace(" /", "\\");
                var result = _dbContext.AddUpdateAttachment.FromSqlRaw("exec AddUpdateAttachment @TempAttachmentID={0},@TempSubCourseID={1},@TempAttachmentDuration={2},@TempDescription={3},@TempFileName={4},@TempFilePath={5},@TempAttachmentType={6},@TempUser={7}", attachment.AttachmentId, attachment.SubCourseId, attachment.AttachmentDuration, attachment.Description, attachment.FileName, attachment.FilePath, attachment.AttachmentType, "Elite4").ToList();

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
                _response.Success = false;
                _response.Message = "Something Went Wrong";

            }
            return await Task.FromResult(_response);
        }
    }

}
