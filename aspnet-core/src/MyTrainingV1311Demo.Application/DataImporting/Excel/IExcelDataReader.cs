using System.Collections.Generic;
using Abp.Dependency;

namespace MyTrainingV1311Demo.DataImporting.Excel;

public interface IExcelDataReader<TEntityDto> : ITransientDependency
{
    List<TEntityDto> GetEntitiesFromExcel(byte[] fileBytes);
}