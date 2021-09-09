using Abp.Application.Services;
using Abp.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VillageBoard.Campuses
{
    public class CampusAppService : CrudAppService<Campus, CampusDto>
    {
        public CampusAppService(IRepository<Campus, int> repository) : base(repository)
        {
        }
    }
}
