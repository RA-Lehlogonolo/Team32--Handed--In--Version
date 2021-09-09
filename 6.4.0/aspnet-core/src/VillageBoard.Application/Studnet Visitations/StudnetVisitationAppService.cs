using Abp.Application.Services;
using Abp.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VillageBoard.Student_Visitations;

namespace VillageBoard.Studnet_Visitations
{
    public class StudnetVisitationAppService : CrudAppService<Studnet_Visitation, StudentVisitationDto>
    {
        public StudnetVisitationAppService(IRepository<Studnet_Visitation, int> repository) : base(repository)
        {

        }
    }
}
