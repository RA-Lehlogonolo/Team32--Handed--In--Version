using Abp.Application.Services;
using Abp.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VillageBoard.Item_Types
{
     public class ItemTypeAppService : CrudAppService<Item_Type, ItemTypeDto>
    {
        public ItemTypeAppService(IRepository<Item_Type, int> repository) : base(repository)
        {

        }
    }
}
