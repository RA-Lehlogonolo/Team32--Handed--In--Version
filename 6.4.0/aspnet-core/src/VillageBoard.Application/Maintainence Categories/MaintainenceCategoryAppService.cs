using Abp.Application.Services;
using Abp.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VillageBoard.Maintainence_Categories
{
    public class MaintainenceCategoryAppService : CrudAppService<Maintainence_Category, MaintainenceCategoryDto>
    {
        public MaintainenceCategoryAppService(IRepository<Maintainence_Category, int> repository) : base(repository)
        {

        }
    }
}
