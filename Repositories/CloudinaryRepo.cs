using CloudinaryDotNet.Actions;
using Microsoft.AspNetCore.Http;
using NewSoftlearn.InterfaceRepositories;
using Microsoft.AspNetCore.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NewSoftlearn.Services.Cloudinary;
using CloudinaryDotNet;
using System.IO;

namespace NewSoftlearn.Repositories
{
    public class CloudinaryRepo : ICloudinaryRepo
    {
        private readonly CloudinaryConfig _cloudinaryConfig;
        private IHostingEnvironment _hostingEnvironment;

        public CloudinaryRepo(CloudinaryConfig cloudinaryConfig, IHostingEnvironment environment)
        {
            _cloudinaryConfig = cloudinaryConfig;
            _hostingEnvironment = environment;
        }

        public async Task<ImageUploadResult> CategoryImagesUpload(IFormFile file)
        {
            try
            {
                Account account = new Account(_cloudinaryConfig.Cloud, _cloudinaryConfig.ApiKey, _cloudinaryConfig.ApiSecret);
                Cloudinary cloudinary = new Cloudinary(account);

                // var path = Path.Combine(Directory.GetCurrentDirectory(), "TempFileUpload", file.FileName);
                var path = Path.Combine(_hostingEnvironment.WebRootPath, file.FileName);

                using (var stream = new FileStream(path, FileMode.Create))
                {
                    await file.CopyToAsync(stream);
                }

                //Uploads the Course Images to cloudinary
                var uploadParams = new ImageUploadParams()
                {
                    File = new FileDescription(path),
                    Transformation = new Transformation().Height(500).Width(500).Crop("scale"),
                    PublicId = "Softlearn/course_category_Images/" + file.FileName + "",
                };
                var uploadResult = cloudinary.Upload(uploadParams);

                //deletes the file from the "TempFileUplaod" directory if the status of upload result is okay
                if (uploadResult.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    System.IO.File.Delete(path);
                }

                return uploadResult;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<RawUploadResult> DocumentUpload(IFormFile file)
        {
            try
            {
                Account account = new Account(_cloudinaryConfig.Cloud, _cloudinaryConfig.ApiKey, _cloudinaryConfig.ApiSecret);
                Cloudinary cloudinary = new Cloudinary(account);

                //var path = Path.Combine(Directory.GetCurrentDirectory(), "TempFileUpload", file.FileName);
                var path = Path.Combine(_hostingEnvironment.WebRootPath, file.FileName);

                using (var stream = new FileStream(path, FileMode.Create))
                {
                    await file.CopyToAsync(stream);
                }

                //Uploads the Course Images to cloudinary
                var uploadParams = new RawUploadParams()
                {
                    File = new FileDescription(path),
                    PublicId = "Softlearn/course_materials/" + file.FileName + "",
                };
                var uploadResult = cloudinary.Upload(uploadParams);

                //deletes the file from the "TempFileUplaod" directory if the status of upload result is okay
                if (uploadResult.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    System.IO.File.Delete(path);
                }

                return uploadResult;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<ImageUploadResult> ImagesUpload(IFormFile file)
        {
            try
            {
                Account account = new Account(_cloudinaryConfig.Cloud, _cloudinaryConfig.ApiKey, _cloudinaryConfig.ApiSecret);
                Cloudinary cloudinary = new Cloudinary(account);

                // var path = Path.Combine(Directory.GetCurrentDirectory(), "TempFileUpload", file.FileName);
                var path = Path.Combine(_hostingEnvironment.WebRootPath, file.FileName);

                using (var stream = new FileStream(path, FileMode.Create))
                {
                    await file.CopyToAsync(stream);
                }

                //Uploads the Course Images to cloudinary
                var uploadParams = new ImageUploadParams()
                {
                    File = new FileDescription(path),
                    Transformation = new Transformation().Height(500).Width(500).Crop("scale"),
                    PublicId = "Softlearn/course_Images/" + file.FileName + "",
                };
                var uploadResult = cloudinary.Upload(uploadParams);

                //deletes the file from the "TempFileUplaod" directory if the status of upload result is okay
                if (uploadResult.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    System.IO.File.Delete(path);
                }

                return uploadResult;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<VideoUploadResult> VideosUpload(IFormFile file)
        {
            try
            {
                Account account = new Account(_cloudinaryConfig.Cloud, _cloudinaryConfig.ApiKey, _cloudinaryConfig.ApiSecret);
                Cloudinary cloudinary = new Cloudinary(account);

                //var path = Path.Combine(Directory.GetCurrentDirectory(), "TempFileUpload", file.FileName);
                var path = Path.Combine(_hostingEnvironment.WebRootPath, file.FileName);

                using (var stream = new FileStream(path, FileMode.Create))
                {
                    await file.CopyToAsync(stream);
                }

                //Uploads the Course Images to cloudinary
                var uploadParams = new VideoUploadParams()
                {
                    File = new FileDescription(path),
                    Transformation = new Transformation().Height(500).Width(500).Crop("scale"),
                    PublicId = "Softlearn/course_videos/" + file.FileName + "",
                };
                var uploadResult = cloudinary.Upload(uploadParams);

                //deletes the file from the "TempFileUplaod" directory if the status of upload result is okay
                if (uploadResult.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    System.IO.File.Delete(path);
                }

                return uploadResult;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
