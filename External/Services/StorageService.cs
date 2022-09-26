using Azure.Storage.Blobs;
using Azure.Storage.Blobs.Models;
using Samauma.UseCases.Interfaces.Services;
using System.Text.RegularExpressions;

namespace Samauma.External.Services;

public class StorageService: IStorageService
{
    private IConfiguration _configuration { get; }
    private static string DefaultExtension => "png";

    public StorageService(IConfiguration configuration)
    {
        _configuration = configuration;
    }

    public string UploadTreeImageInBase64(string Base64Image)
    {
        return UploadImageInBase64(Base64Image, _configuration["Storage:TreeContainerName"]);
    }

    public string UploadTreeImageInBase64(string Base64Image, string fileUri)
    {
        return UploadImageInBase64(Base64Image, _configuration["Storage:TreeContainerName"], fileUri);
    }

    private string UploadImageInBase64(string Base64Image, string ContainerName)
    {
        string fileName = Guid.NewGuid().ToString() + "." + DefaultExtension;
        var FileUri = string.Concat(_configuration["Storage:TreeCdnUrl"], "/", ContainerName, "/", fileName);
        var BlobClient = new BlobClient(_configuration["Storage:ConnectionString"], ContainerName, fileName);
        var Data = new Regex(@"^data:image\/[a-z]+;base64,").Replace(Base64Image, "");
        byte[] ImageBytes = Convert.FromBase64String(Data);

        UploadImageToBlob(BlobClient, ImageBytes);

        return FileUri;
    }

    private string UploadImageInBase64(string Base64Image, string ContainerName, string fileUri)
    {
        string fileName = fileUri.Split("/").Last();
        var BlobClient = new BlobClient(_configuration["Storage:ConnectionString"], ContainerName, fileName);
        var Data = new Regex(@"^data:image\/[a-z]+;base64,").Replace(Base64Image, ""); 
        byte[] ImageBytes = Convert.FromBase64String(Data);

        UploadImageToBlob(BlobClient, ImageBytes);

        return fileUri;
    }

    private static BlobUploadOptions GetBlobUploadOptions()
    {
        return new BlobUploadOptions
        {
            HttpHeaders = new BlobHttpHeaders()
            {
                ContentType = "image/" + DefaultExtension
            }
        };
    }

    private static void UploadImageToBlob(BlobClient BlobClient, byte[] ImageBytes)
    {
        using var Stream = new MemoryStream(ImageBytes);
            BlobClient.Upload(Stream, GetBlobUploadOptions());
    }
}

