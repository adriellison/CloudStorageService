using CloudStorageService.Domain.Entities;
using CloudStorageService.Domain.Storage;
using Microsoft.AspNetCore.Http;

namespace CloudStorageService.Infrastructure.Storage;
internal class DropboxStorageService : IStorageService
{
    public string Upload(IFormFile file, User user)
    {
        throw new NotImplementedException();
    }
}
