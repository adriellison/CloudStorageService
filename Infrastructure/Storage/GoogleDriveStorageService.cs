using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CloudStorageService.Domain.Entities;
using CloudStorageService.Domain.Storage;
using Google.Apis.Drive.v3;
using Microsoft.AspNetCore.Http;

namespace CloudStorageService.Infrastructure.Storage;
internal class GoogleDriveStorageService : IStorageService
{
    public string Upload(IFormFile file, User user)
    {
        var service = new DriveService();

        var driverFile = new Google.Apis.Drive.v3.Data.File
        {
            Name = file.Name,
            MimeType = file.ContentType
            //Parents = Passar ID da pasta para salvar no caminho correto
        };

        var command =  service.Files.Create(driverFile, file.OpenReadStream(), file.ContentType);
        command.Fields = "id";

        var response = command.Upload();

        if (response.Status is not Google.Apis.Upload.UploadStatus.Completed)
            throw response.Exception;

        return command.ResponseBody.Id;
    }
}
