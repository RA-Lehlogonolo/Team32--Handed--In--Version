using Abp.Application.Services;
using Abp.Authorization;
using Abp.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VillageBoard.Authorization;

namespace VillageBoard.Menu_Types
{
    [AbpAuthorize(PermissionNames.Pages_MenuType)]
    public class MenuTypeAppService : CrudAppService<Menu_Type, MenuTypeDto>
    {
        public MenuTypeAppService(IRepository<Menu_Type, int> repository) : base(repository)
        {

        }
    }
}
