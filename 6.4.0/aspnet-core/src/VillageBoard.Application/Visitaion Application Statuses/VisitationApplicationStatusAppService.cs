using Abp.Application.Services;
using Abp.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VillageBoard.Visitation_Application_Statuses;

namespace VillageBoard.Visitaion_Application_Statuses
{
    public class VisitationApplicationStatusAppService : CrudAppService<Visitation_Applicaition_Status, VisitationApplicationStatusDto>
    {
        public VisitationApplicationStatusAppService(IRepository<Visitation_Applicaition_Status, int> repository) : base(repository)
        {

        }
    

    }
}
