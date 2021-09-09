using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using VillageBoard.Authorization;

namespace VillageBoard
{
    [DependsOn(
        typeof(VillageBoardCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class VillageBoardApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<VillageBoardAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(VillageBoardApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
