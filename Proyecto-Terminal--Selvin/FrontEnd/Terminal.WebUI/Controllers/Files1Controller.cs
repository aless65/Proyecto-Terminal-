using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
 using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Terminal.WebUI.Models;

namespace Terminal.WebUI.Controllers
{
    public class Files1Controller : Controller
    {
        IHostingEnvironment _hostingEnviroment = null;

        public Files1Controller(IHostingEnvironment hostingEnvironment)
        {
            _hostingEnviroment = hostingEnvironment;
        }


        [HttpGet]
        public IActionResult Index(string Filename = "")
        {

            FileClass fileObj = new FileClass();
            fileObj.Name = Filename;

            string path = $"{_hostingEnviroment.WebRootPath}\\files\\";
            int nId = 1;

            foreach (string pdfPath in Directory.EnumerateFiles(path, "*.pdf"))
            {
                fileObj.Files.Add(new FileClass()
                {
                    FileId = nId++,
                    Name = Path.GetFullPath(pdfPath),
                    Path = pdfPath
                });
            }
            return View(fileObj);
        }

        [HttpPost]
        public IActionResult Index(IFormFile file, [FromServices] IHostingEnvironment hostingEnvironment)
        {

            string fileName = $"{hostingEnvironment.WebRootPath}\\files\\{file.FileName}";
            using (FileStream fileStream = System.IO.File.Create(fileName))
            {
                file.CopyTo(fileStream);
                fileStream.Flush();
            }

            return Index();
        }

        public IActionResult PdfViewNewTab(string fileName)
        {
            string path = _hostingEnviroment.WebRootPath + "\\files\\" + fileName;
            return File(System.IO.File.ReadAllBytes(path), "aplicaction/pdf");
        }

    }
}
