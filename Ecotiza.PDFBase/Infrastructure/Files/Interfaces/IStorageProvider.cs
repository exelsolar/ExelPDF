using System.Collections.Generic;
using System.IO;
using Ecotiza.PDFBase.Infrastructure.Files.Enums;

namespace Ecotiza.PDFBase.Infrastructure.Files.Interfaces
{
    public interface IStorageProvider
    {
        string Save(IFile file, EFileContainer fileContainer, int identifier);
        string Save(IFile file, EFileContainer fileContainer, string identifier);
        Stream Retrieve(string filePath, EFileContainer fileContainer);
        void Delete(string filePath, EFileContainer fileContainer);
        string DomainResolver(string filePath, EFileContainer fileContainer);
        bool HasFile(string filePath);
        string PathResolver(string filePath, EFileContainer fileContainer);
    }
}