using CloudStorageService.Domain.Entities;
using Microsoft.AspNetCore.Http;

namespace CloudStorageService.Domain.Storage;
public interface IStorageService
{
    string Upload(IFormFile file, User user);
}