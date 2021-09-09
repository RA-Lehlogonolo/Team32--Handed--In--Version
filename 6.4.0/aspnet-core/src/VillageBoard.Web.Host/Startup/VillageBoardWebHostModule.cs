using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using VillageBoard.Configuration;

namespace VillageBoard.Web.Host.Startup
{
    [DependsOn(
       typeof(VillageBoardWebCoreModule))]
    public class VillageBoardWebHostModule: AbpModule
    {
        private readonly IWebHostEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public VillageBoardWebHostModule(IWebHostEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(VillageBoardWebHostModule).GetAssembly());
        }
    }
}
