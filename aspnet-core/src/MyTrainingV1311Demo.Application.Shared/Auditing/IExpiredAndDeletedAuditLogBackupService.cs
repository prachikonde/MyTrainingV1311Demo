using System.Collections.Generic;
using Abp.Auditing;

namespace MyTrainingV1311Demo.Auditing
{
    public interface IExpiredAndDeletedAuditLogBackupService
    {
        bool CanBackup();
        
        void Backup(List<AuditLog> auditLogs);
    }
}