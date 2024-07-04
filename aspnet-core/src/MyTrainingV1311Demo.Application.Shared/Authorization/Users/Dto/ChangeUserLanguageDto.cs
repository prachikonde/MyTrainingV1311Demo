using System.ComponentModel.DataAnnotations;

namespace MyTrainingV1311Demo.Authorization.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}
