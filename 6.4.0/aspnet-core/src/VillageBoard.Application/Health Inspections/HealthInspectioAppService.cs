using Abp.Application.Services;
using Abp.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VillageBoard.Health_Inspections
{
    public class HealthInspectioAppService : CrudAppService<Health_Inspection, HealthInspectionDto>
    {
        public HealthInspectioAppService(IRepository<Health_Inspection, int> repository) : base(repository)
        {

        }
    }
}
