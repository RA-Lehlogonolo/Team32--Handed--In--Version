using Abp.Application.Services;
using Abp.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VillageBoard.Health_Inspection_Types
{
    public class HealthInpectionTypeAppSerivce : CrudAppService<Health_Inpsection_Type, HealthInpsectionTypeDto>

    {
        public HealthInpectionTypeAppSerivce(IRepository<Health_Inpsection_Type, int> repository) : base(repository)
        {

        }
    }
}
