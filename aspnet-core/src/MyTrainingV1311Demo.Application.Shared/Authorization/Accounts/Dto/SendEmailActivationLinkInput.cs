using System.ComponentModel.DataAnnotations;

namespace MyTrainingV1311Demo.Authorization.Accounts.Dto
{
    public class SendEmailActivationLinkInput
    {
        [Required]
        public string EmailAddress { get; set; }
    }
}