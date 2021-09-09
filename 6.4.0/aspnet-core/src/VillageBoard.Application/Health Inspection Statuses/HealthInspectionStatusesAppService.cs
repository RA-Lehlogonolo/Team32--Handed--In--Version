using Abp.Application.Services;
using Abp.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VillageBoard.Health_Inspection_Statuses
{
   public  class HealthInspectionStatusesAppService :  CrudAppService<Health_Inspection_Status, HealthInspectionStatusDto>
    {
        public HealthInspectionStatusesAppService(IRepository<Health_Inspection_Status, int> repository) : base(repository)
        {

        }
    }
}
