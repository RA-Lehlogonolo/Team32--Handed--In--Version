using Abp.Application.Services;
using Abp.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VillageBoard.Items
{
    public class ItemAppService   : CrudAppService<Item, ItemDto>
    {
        public ItemAppService(IRepository<Item, int> repository) : base(repository)
        {
            
        }
    }
}
