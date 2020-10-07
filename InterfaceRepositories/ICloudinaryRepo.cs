using CloudinaryDotNet.Actions;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewSoftlearn.InterfaceRepositories
{
    public interface ICloudinaryRepo
    {
        Task<ImageUploadResult> ImagesUpload(IFormFile file);
        Task<ImageUploadResult> CategoryImagesUpload(IFormFile file);
        Task<RawUploadResult> DocumentUpload(IFormFile file);
        Task<VideoUploadResult> VideosUpload(IFormFile file);
    }
}
