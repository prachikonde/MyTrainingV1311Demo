using System.Collections.Generic;
using Abp.Dependency;
using MyTrainingV1311Demo.Dto;

namespace MyTrainingV1311Demo.DataImporting.Excel;

public interface IExcelInvalidEntityExporter<TEntityDto> : ITransientDependency
{
    FileDto ExportToFile(List<TEntityDto> entities);
}