using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace VillageBoard.Controllers
{
    public abstract class VillageBoardControllerBase: AbpController
    {
        protected VillageBoardControllerBase()
        {
            LocalizationSourceName = VillageBoardConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
