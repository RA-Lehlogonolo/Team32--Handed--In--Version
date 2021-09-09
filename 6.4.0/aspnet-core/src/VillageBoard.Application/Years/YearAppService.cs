using Abp.Application.Services;
using Abp.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VillageBoard.Years
{
    public class YearAppService : CrudAppService<Year, YearDto>
    {
        public YearAppService(IRepository<Year, int> repository) : base(repository)
        {

        }
    }
}
