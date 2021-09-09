using Abp.Application.Services;
using Abp.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VillageBoard.Menu_Types
{
   public class MenuTypeAppService : CrudAppService<Menu_Type, MenuTypeDto>
    {
        public MenuTypeAppService(IRepository<Menu_Type, int> repository) : base(repository)
        {

        }
    }
}
