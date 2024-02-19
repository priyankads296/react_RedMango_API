using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RedMango_API.Services
{
    public interface IBlobService
    {

        //for handling images ,blob is the files present in storage account
        Task<string> GetBlob(string blobName, string containerName);
        Task<bool> DeleteBlob(string blobName, string containerName);
        Task<string> UploadBlob(string blobName, string containerName, IFormFile file); //creating blob 
    }
}
