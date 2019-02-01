using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using Ecotiza.PDFBase.Infrastructure.Files.Enums;
using Ecotiza.PDFBase.Infrastructure.Files.Interfaces;

namespace Ecotiza.PDFBase.Infrastructure.Files
{
    public class ZipFileProvider
    {
        private readonly IFileResolver _fileResolver;
        private readonly string _destinationPath = FileSettings.ContentFolder;
        public ZipFileProvider()
        {
        }
        public ZipFileProvider(IFileResolver fileResolver)
        {
            _fileResolver = fileResolver;
        }

        /// <summary>
        /// Agrega un archivo al zip
        /// </summary>
        /// <param name="identifier">Identificador del Zip</param>
        /// <param name="entryName">Nombre del elemento en el zip</param>
        /// <param name="FileInBytes">Informacion en Bytes que corresponde al elemento a subir</param>
        /// <param name="fileMode">Modo del archivo</param>
        public void AddOrUpdateFile(int identifier, EFileContainer fileContainer, string entryName, byte[] fileInBytes, FileMode fileMode)
        {
            var fullFileName = string.Format("{0}_{1}.zip", identifier, fileContainer);
            var physicalPath = string.Concat(_fileResolver.Resolve(_destinationPath + fileContainer + "/"), fullFileName);

            using (FileStream zipToOpen = new FileStream(physicalPath, fileMode))
            {
                using (ZipArchive archive = new ZipArchive(zipToOpen, ZipArchiveMode.Update))
                {
                    ZipArchiveEntry readmeEntry = archive.GetEntry(entryName);
                    if (readmeEntry == null)
                    {
                        readmeEntry = archive.CreateEntry(entryName);
                    }
                    using (BufferedStream writer = new BufferedStream(readmeEntry.Open()))
                    {
                        writer.Write(fileInBytes, 0, fileInBytes.Length);
                    }
                }
            }
        }
        /// <summary>
        /// Agrega un archivo al zip
        /// </summary>
        /// <param name="entryName">Nombre del elemento en el zip</param>
        /// <param name="fileStream">Informacion en Stream que corresponde al elemento a subir</param>
        public Stream CreateFileZip(string entryName, Stream fileStream)
        {

            Stream zipo = new MemoryStream();
            using (ZipArchive archive = new ZipArchive(zipo, ZipArchiveMode.Create, true))
            {
                var file = archive.CreateEntry(entryName);
                var entry = file.Open();
                fileStream.CopyTo(entry);

            }
            zipo.Seek(0, SeekOrigin.Begin);
            return zipo;
        }

        public Stream CreateFileZips(string entryName, Dictionary<string, Stream> fileStreams)
        {
            Dictionary<string, string> Values = new Dictionary<string, string>();
            Stream memoryStream = new MemoryStream();
            
                //string zip = @"C:\Temp\ZipFile.zip";
                using (var archive = new ZipArchive(memoryStream, ZipArchiveMode.Create, true))
                {
                    foreach (var item in Values)
                    {
                        var file = archive.CreateEntry(item.Key + ".txt");
                        var entryStream = file.Open();
                        using (var streamWriter = new StreamWriter(entryStream))
                        {
                            streamWriter.Write(item.Value);

                        }
                        memoryStream.CopyTo(entryStream);
                    }
                }
                /*using (var fileStream = new FileStream(zip, FileMode.Create))
                {
                    
                }*/
            memoryStream.Seek(0, SeekOrigin.Begin);
            return memoryStream;
        }
        /// <summary>
        /// Elimina un archivo dentro del zip
        /// </summary>
        /// <param name="EntryName">Nombre Identificador dentro del zip</param>
        public void DeleteFile(int identifier, EFileContainer fileContainer, string entryName)
        {
            var fullFileName = string.Format("{0}_{1}.zip", identifier, fileContainer);
            var physicalPath = string.Concat(_fileResolver.Resolve(_destinationPath + fileContainer + "/"), fullFileName);

            using (FileStream zipToOpen = new FileStream(physicalPath, FileMode.Open))
            {
                using (ZipArchive archive = new ZipArchive(zipToOpen, ZipArchiveMode.Update))
                {
                    ZipArchiveEntry readmeEntry = archive.GetEntry(entryName);
                    if (readmeEntry != null)
                    {
                        readmeEntry.Delete();
                    }
                }
            }
        }
    }
}
