using System.Collections.Generic;
using Abp;
using MyTrainingV1311Demo.Chat.Dto;
using MyTrainingV1311Demo.Dto;

namespace MyTrainingV1311Demo.Chat.Exporting
{
    public interface IChatMessageListExcelExporter
    {
        FileDto ExportToFile(UserIdentifier user, List<ChatMessageExportDto> messages);
    }
}
