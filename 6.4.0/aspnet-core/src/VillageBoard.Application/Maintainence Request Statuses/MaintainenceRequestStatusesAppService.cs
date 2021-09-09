using Abp.Application.Services;
using Abp.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VillageBoard.Maintainence_Request_Statuses
{
     public class MaintainenceRequestStatusesAppService : CrudAppService<Maintainence_Request_Status, MaintainenceRequestStatusDto>
    {
        public MaintainenceRequestStatusesAppService(IRepository<Maintainence_Request_Status, int> repository) : base(repository)
        {

        }
    }
}
