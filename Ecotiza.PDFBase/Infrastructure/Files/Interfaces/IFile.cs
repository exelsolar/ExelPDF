using System.IO;

namespace Ecotiza.PDFBase.Infrastructure.Files.Interfaces
{
    public interface IFile
    {
        Stream Stream { get; set; }
        string ContentType { get; set; }
        string Name { get; set; }
        string Extension { get; }
    }
}