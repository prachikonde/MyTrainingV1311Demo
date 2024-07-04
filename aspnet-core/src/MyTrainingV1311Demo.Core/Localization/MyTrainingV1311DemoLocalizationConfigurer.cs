using System.Reflection;
using Abp.Configuration.Startup;
using Abp.Localization.Dictionaries;
using Abp.Localization.Dictionaries.Xml;
using Abp.Reflection.Extensions;

namespace MyTrainingV1311Demo.Localization
{
    public static class MyTrainingV1311DemoLocalizationConfigurer
    {
        public static void Configure(ILocalizationConfiguration localizationConfiguration)
        {
            localizationConfiguration.Sources.Add(
                new DictionaryBasedLocalizationSource(
                    MyTrainingV1311DemoConsts.LocalizationSourceName,
                    new XmlEmbeddedFileLocalizationDictionaryProvider(
                        typeof(MyTrainingV1311DemoLocalizationConfigurer).GetAssembly(),
                        "MyTrainingV1311Demo.Localization.MyTrainingV1311Demo"
                    )
                )
            );
        }
    }
}