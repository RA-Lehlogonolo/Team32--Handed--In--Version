using Abp.Application.Services;
using Abp.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VillageBoard.Days
{
  public  class DayAppService : CrudAppService<Day, DayDto>
    {
        public DayAppService(IRepository<Day, int> repository) : base(repository)
        {

        }
    }
}
