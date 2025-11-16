using System.IO;
using System.Threading.Tasks;
using TypeInMD.Core.Models;

namespace TypeInMD.Core.Interfaces
{
    public interface IFileConverter
    {
        Task<MemoryStream> HtmlToPdf(string html, PdfPrintSettings settings = null);
    }
}
