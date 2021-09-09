using Abp.AspNetCore;
using Abp.AspNetCore.TestBase;
using Abp.Modules;
using Abp.Reflection.Extensions;
using VillageBoard.EntityFrameworkCore;
using VillageBoard.Web.Startup;
using Microsoft.AspNetCore.Mvc.ApplicationParts;

namespace VillageBoard.Web.Tests
{
    [DependsOn(
        typeof(VillageBoardWebMvcModule),
        typeof(AbpAspNetCoreTestBaseModule)
    )]
    public class VillageBoardWebTestModule : AbpModule
    {
        public VillageBoardWebTestModule(VillageBoardEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbContextRegistration = true;
        } 
        
        public override void PreInitialize()
        {
            Configuration.UnitOfWork.IsTransactional = false; //EF Core InMemory DB does not support transactions.
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(VillageBoardWebTestModule).GetAssembly());
        }
        
        public override void PostInitialize()
        {
            IocManager.Resolve<ApplicationPartManager>()
                .AddApplicationPartsIfNotAddedBefore(typeof(VillageBoardWebMvcModule).Assembly);
        }
    }
}