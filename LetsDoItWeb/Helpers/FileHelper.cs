using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;

namespace LetsDoItWeb.Helpers
{
    public class FileHelper
    {

        private readonly IWebHostEnvironment _webHostEnvironment;
        public FileHelper(IWebHostEnvironment webHostEnvironment)
        {
            _webHostEnvironment = webHostEnvironment;

        }
        public async Task<string> SaveFile(IFormFile file)
        {
            if (file == null)
                return "";
            string uploads = _webHostEnvironment.WebRootPath;
            if (!Directory.Exists(Path.Combine(uploads, "uploads")))
                Directory.CreateDirectory(Path.Combine(uploads, "uploads"));
            string fileName = "uploads/" + Path.GetRandomFileName() + file.FileName.Substring(file.FileName.LastIndexOf(".", file.FileName.Length));
            string filePath = Path.Combine(uploads, fileName);
            using (Stream fileStream = new FileStream(filePath, FileMode.Create))
            {
                await file.CopyToAsync(fileStream);
            }

            return fileName;
        }
    }
}
