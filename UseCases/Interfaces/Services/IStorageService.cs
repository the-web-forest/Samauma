﻿namespace Samauma.UseCases.Interfaces.Services;
public interface IStorageService
{
    string UploadTreeImageInBase64(string Base64Image);
    string UploadTreeImageInBase64(string Base64Image, string fileUri);
}