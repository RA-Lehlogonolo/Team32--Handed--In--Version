using Abp.Application.Services;
using Abp.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VillageBoard.Statuses
{
    public class StatusAppService : CrudAppService<Status, StatusDto>
    {
        public StatusAppService(IRepository<Status, int> repository) : base(repository)
        {

        }
    }
}
