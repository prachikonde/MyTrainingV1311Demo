using System.Threading.Tasks;

namespace MyTrainingV1311Demo.Security
{
    public interface IPasswordComplexitySettingStore
    {
        Task<PasswordComplexitySetting> GetSettingsAsync();
    }
}
