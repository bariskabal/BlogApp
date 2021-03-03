using System;
using System.IO;
using System.Threading.Tasks;
using BlogApp.WebApi.Enums;
using BlogApp.WebApi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BlogApp.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BaseController : ControllerBase
    {
        [HttpGet("[action]")]
        public async  Task<UploadModel> UploadFileAsync(IFormFile file,string contentType)
        {
            UploadModel uploadModel = new UploadModel();
            if(file!=null)
            {
                if(file.ContentType!=contentType)
                {
                    uploadModel.ErrorMessage = "Uygunsuz dosya türü";
                    uploadModel.UploadState= UploadState.Error;
                    return uploadModel;
                }
                else{
                    var newName = Guid.NewGuid() + Path.GetExtension(file.FileName);
                    var path = Path.Combine(Directory.GetCurrentDirectory(),"wwwroot/img/"+ newName);
                    var stream = new FileStream(path,FileMode.Create);
                    await file.CopyToAsync(stream);

                    uploadModel.NewName = newName;
                    uploadModel.UploadState= UploadState.Success;
                    return uploadModel;
                    
                }
                
            }
            uploadModel.ErrorMessage= "Dosya yok";
            uploadModel.UploadState = UploadState.NotExist;
            return uploadModel;
        }
    }
}