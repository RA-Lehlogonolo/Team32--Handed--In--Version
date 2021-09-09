using Abp.Application.Services;
using Abp.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VillageBoard.Order_Statuses
{
    public class OrderStatusAppService   : CrudAppService<Order_Status, OrderStatusDto>
    {
        public OrderStatusAppService(IRepository<Order_Status, int> repository) : base(repository)
        {

        }
    }
}
