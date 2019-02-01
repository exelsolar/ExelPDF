using System.Collections.Generic;
using System.IO;
using System.Linq;
using Ecotiza.PDFBase.Infrastructure.Files.Enums;
using Ecotiza.PDFBase.Infrastructure.Files.Interfaces;

namespace Ecotiza.PDFBase.Infrastructure.Files
{
    public class StorageProvider : IStorageProvider
    {
        private readonly IFileResolver _fileResolver;
        private readonly string _destinationPath = FileSettings.ContentFolder;

        public StorageProvider(IFileResolver fileResolver)
        {
            _fileResolver = fileResolver;
        }

        public string Save(IFile file, EFileContainer fileContainer, int identifier)
        {
            var fullFileName = string.Format("{0}_{1}.{2}", identifier, fileContainer, file.Extension);
            var physicalPath = string.Concat(_fileResolver.Resolve(_destinationPath + fileContainer + "/"), fullFileName);

            using (var fileStream = System.IO.File.Create(physicalPath))
            {
                file.Stream.Seek(0, SeekOrigin.Begin);
                file.Stream.CopyTo(fileStream);
            }

            return fullFileName;
        }

        public string Save(IFile file, EFileContainer fileContainer, string identifier)
        {
            var fullFileName = string.Format("{0}_{1}.{2}", identifier, fileContainer, file.Extension);
            var physicalPath = string.Concat(_fileResolver.Resolve(_destinationPath + fileContainer + "/"), fullFileName);

            using (var fileStream = System.IO.File.Create(physicalPath))
            {
                file.Stream.Seek(0, SeekOrigin.Begin);
                file.Stream.CopyTo(fileStream);
            }

            return fullFileName;
        }

        public Stream Retrieve(string filePath, EFileContainer fileContainer)
        {
            var fileLocation = _fileResolver.Resolve(_destinationPath + fileContainer + "/" + filePath);
            var fileStream = new FileStream(fileLocation, FileMode.Open, FileAccess.Read, FileShare.Read);
            return fileStream;
        }

        public bool HasFile(string filePath)
        {
            var fileLocation = _fileResolver.Resolve(_destinationPath + filePath);
            return System.IO.File.Exists(fileLocation);
        }

        public void Delete(string filePath, EFileContainer fileContainer)
        {
            var fileLocation = _fileResolver.Resolve(_destinationPath + fileContainer + "/" + filePath);
            System.IO.File.Delete(fileLocation);
        }

        public string DomainResolver(string filePath, EFileContainer fileContainer)
        {
            var appPath = string.Format("{0}{1}", ServerDomainResolver.GetCurrentDomain(), _destinationPath + fileContainer + "/" + filePath);
            return appPath;
        }

        public IEnumerable<string> ReadAllLinesCsv(string filePath)
        {
            var physicalPath = string.Concat(_fileResolver.Resolve(_destinationPath), filePath);
            var csvLines = System.IO.File.ReadAllLines(physicalPath).Skip(1);
            return csvLines;
        }

        public string PathResolver(string filePath, EFileContainer fileContainer)
        {
            return string.Concat(_fileResolver.Resolve(_destinationPath + fileContainer + "/"), filePath);
        }
    }
}