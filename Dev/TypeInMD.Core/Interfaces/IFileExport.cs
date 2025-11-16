using System.Collections.ObjectModel;
using System.Threading.Tasks;
using TypeInMD.Core.Enums;
using TypeInMD.Core.Models;

namespace TypeInMD.Core.Interfaces
{
    public interface IFileExport
    {
        ObservableCollection<ExportConfig> ExportConfigs { get; }

        Task<ExportConfig> AddExportConfig(string name = null, ExportType type = 0);

        Task RemoveExportConfig(int id);

        Task<bool> SaveExportConfig(ExportConfig config);

        Task<ExportConfig> GetExportConfig(int id);

        Task UpdateExportConfigs();

        Task Print(string basePath, string html, string documentName = null);
    }
}
