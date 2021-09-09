using Abp.Application.Services;
using Abp.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VillageBoard.Residence_Types
{
    public class ResidenceTypeAppService : CrudAppService<Residence_Type, ResidenceTypeDto>
    {
        public ResidenceTypeAppService(IRepository<Residence_Type, int> repository) : base(repository)
        {

        }
    }
}
