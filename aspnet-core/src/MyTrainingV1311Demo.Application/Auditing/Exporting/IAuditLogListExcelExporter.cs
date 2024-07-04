using System.Collections.Generic;
using MyTrainingV1311Demo.Auditing.Dto;
using MyTrainingV1311Demo.Dto;

namespace MyTrainingV1311Demo.Auditing.Exporting
{
    public interface IAuditLogListExcelExporter
    {
        FileDto ExportToFile(List<AuditLogListDto> auditLogListDtos);

        FileDto ExportToFile(List<EntityChangeListDto> entityChangeListDtos);
    }
}
