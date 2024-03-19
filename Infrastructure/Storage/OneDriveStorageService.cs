using CloudStorageService.Domain.Entities;
using CloudStorageService.Domain.Storage;
using Microsoft.AspNetCore.Http;

namespace CloudStorageService.Infrastructure.Storage;
internal class OneDriveStorageService : IStorageService
{
    public string Upload(IFormFile file, User user)
    {
        throw new NotImplementedException();
    }
}
