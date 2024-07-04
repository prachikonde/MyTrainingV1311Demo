using System.Threading.Tasks;
using MyTrainingV1311Demo.Security.Recaptcha;

namespace MyTrainingV1311Demo.Test.Base.Web
{
    public class FakeRecaptchaValidator : IRecaptchaValidator
    {
        public Task ValidateAsync(string captchaResponse)
        {
            return Task.CompletedTask;
        }
    }
}
