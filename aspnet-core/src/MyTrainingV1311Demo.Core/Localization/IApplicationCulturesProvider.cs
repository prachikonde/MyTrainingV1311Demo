using System.Globalization;

namespace MyTrainingV1311Demo.Localization
{
    public interface IApplicationCulturesProvider
    {
        CultureInfo[] GetAllCultures();
    }
}