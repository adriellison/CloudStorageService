using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CloudStorageService.Domain.Entities;
using CloudStorageService.Domain.Storage;
using Microsoft.AspNetCore.Http;

namespace CloudStorageService.Infrastructure.Storage;
internal class GoogleDriveStorageService : IStorageService
{
    public string Upload(IFormFile file, User user)
    {
        throw new NotImplementedException();
    }
}
