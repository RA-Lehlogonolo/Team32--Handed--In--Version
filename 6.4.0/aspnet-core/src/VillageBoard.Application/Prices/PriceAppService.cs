using Abp.Application.Services;
using Abp.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VillageBoard.Prices
{
    public class PriceAppService : CrudAppService<Price, PriceDto>
    {
        public PriceAppService(IRepository<Price, int> repository) : base(repository)
        {

        }
    }
}
