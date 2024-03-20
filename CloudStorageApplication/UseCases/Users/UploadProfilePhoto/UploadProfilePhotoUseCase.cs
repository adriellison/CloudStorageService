using CloudStorageService.Domain.Entities;
using CloudStorageService.Domain.Storage;
using FileTypeChecker.Extensions;
using FileTypeChecker.Types;
using Microsoft.AspNetCore.Http;

namespace CloudStorageApplication.UseCases.Users.UploadProfilePhoto;
public class UploadProfilePhotoUseCase
{
    private readonly IStorageService _storageService;

    public UploadProfilePhotoUseCase(IStorageService storageService)
    {
        _storageService = storageService;
    }

    public void Execute(IFormFile file)
    {
        var fileStream = file.OpenReadStream();

        bool ImageIsValid = fileStream.Is<JointPhotographicExpertsGroup>() || fileStream.Is<PortableNetworkGraphic>();

        if(!ImageIsValid)
            throw new Exception("The file is not an Image");

        var user = GetFromDatabase();

        _storageService.Upload(file, user);
    }

    private User GetFromDatabase()
    {
        return new User
        {
            Id = 1,
            Name = "Adriellison",
            Email = "adriellisonki@gmail.com"
        };
    }
}