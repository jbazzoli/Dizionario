using Microsoft.AspNetCore.Http;

namespace NeperiaDizionarioV2.Models
{
    public class FileInputModel
    {
         public IFormFile FileToUpload { get; set; }
    }
}