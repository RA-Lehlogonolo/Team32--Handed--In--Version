using Abp.Application.Services;
using Abp.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VillageBoard.Orders;

namespace VillageBoard.Orders
{
  public  class OrderAppService : CrudAppService<Order, OrderDto>
    {
        public OrderAppService(IRepository<Order, int> repository) : base(repository)
        {

        }
    }
}
