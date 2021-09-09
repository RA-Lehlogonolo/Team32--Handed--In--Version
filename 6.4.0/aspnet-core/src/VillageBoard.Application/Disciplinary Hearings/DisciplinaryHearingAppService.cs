using Abp.Application.Services;
using Abp.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VillageBoard.Disciplinary_Hearings
{
    class DisciplinaryHearingAppService : CrudAppService<Disciplinary_Hearing, DisciplinaryHearingDto>
    {
        public DisciplinaryHearingAppService(IRepository<Disciplinary_Hearing, int> repository) : base(repository)
        {

        }
    }
}
