using BusinessLogic;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatterns.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class XmlOperationsController : Controller
    {
        private readonly IFileReaderAction _fileReader;

        public XmlOperationsController(IFileReaderAction _fileReader)
        {
            this._fileReader = _fileReader;
        }

        [HttpGet]
        public async Task<string> ReadXml(string path)
        {
            return _fileReader.Read(path);
        }
    }
}
