using System.ComponentModel.DataAnnotations;

namespace MyTrainingV1311Demo.Authorization.Accounts.Dto
{
    public class ImpersonateUserInput
    {
        public int? TenantId { get; set; }
    
        [Range(1, long.MaxValue)]
        public long UserId { get; set; }
    }
}
