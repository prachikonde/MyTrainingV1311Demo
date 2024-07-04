using System.Collections.Generic;
using System.IO;
using Abp.AspNetZeroCore.Net;
using Abp.Dependency;
using MiniExcelLibs;
using MyTrainingV1311Demo.Dto;
using MyTrainingV1311Demo.Storage;

namespace MyTrainingV1311Demo.DataExporting.Excel.MiniExcel
{
    public abstract class MiniExcelExcelExporterBase : MyTrainingV1311DemoServiceBase, ITransientDependency
    {
        private readonly ITempFileCacheManager _tempFileCacheManager;
        
        protected MiniExcelExcelExporterBase(ITempFileCacheManager tempFileCacheManager)
        {
            _tempFileCacheManager = tempFileCacheManager;
        }

        protected FileDto CreateExcelPackage(string fileName, List<Dictionary<string, object>> items)
        {
            var file = new FileDto(fileName, MimeTypeNames.ApplicationVndOpenxmlformatsOfficedocumentSpreadsheetmlSheet);
            
            Save(items, file);

            return file;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="items"></param>
        /// <param name="file"></param>
        protected virtual void Save(List<Dictionary<string, object>> items, FileDto file)
        {
            using (var stream = new MemoryStream())
            {
                stream.SaveAs(items);
                _tempFileCacheManager.SetFile(file.FileToken, stream.ToArray());
            }
        }
    }
}
