using Abp.Configuration.Startup;
using Abp.Localization.Dictionaries;
using Abp.Localization.Dictionaries.Xml;
using Abp.Reflection.Extensions;

namespace VillageBoard.Localization
{
    public static class VillageBoardLocalizationConfigurer
    {
        public static void Configure(ILocalizationConfiguration localizationConfiguration)
        {
            localizationConfiguration.Sources.Add(
                new DictionaryBasedLocalizationSource(VillageBoardConsts.LocalizationSourceName,
                    new XmlEmbeddedFileLocalizationDictionaryProvider(
                        typeof(VillageBoardLocalizationConfigurer).GetAssembly(),
                        "VillageBoard.Localization.SourceFiles"
                    )
                )
            );
        }
    }
}
