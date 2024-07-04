using System.ComponentModel.DataAnnotations;
using Abp;

namespace MyTrainingV1311Demo.Authorization.Accounts.Dto
{
    public class SwitchToLinkedAccountInput
    {
        public int? TargetTenantId { get; set; }

        [Range(1, long.MaxValue)]
        public long TargetUserId { get; set; }

        public UserIdentifier ToUserIdentifier()
        {
            return new UserIdentifier(TargetTenantId, TargetUserId);
        }
    }
}
