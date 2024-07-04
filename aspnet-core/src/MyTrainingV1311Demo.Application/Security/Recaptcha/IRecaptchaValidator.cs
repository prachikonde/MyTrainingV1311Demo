using System.Threading.Tasks;

namespace MyTrainingV1311Demo.Security.Recaptcha
{
    public interface IRecaptchaValidator
    {
        Task ValidateAsync(string captchaResponse);
    }
}