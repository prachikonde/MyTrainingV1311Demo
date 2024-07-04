using System.ComponentModel.DataAnnotations;

namespace MyTrainingV1311Demo.Localization.Dto
{
    public class CreateOrUpdateLanguageInput
    {
        [Required]
        public ApplicationLanguageEditDto Language { get; set; }
    }
}