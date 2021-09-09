using Abp.Application.Services;
using Abp.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VillageBoard.Sizes
{
    public class SizeAppService : CrudAppService<Size, SizeDto>
    {
        public SizeAppService(IRepository<Size, int> repository) : base(repository)
        {

        }
    }
}
