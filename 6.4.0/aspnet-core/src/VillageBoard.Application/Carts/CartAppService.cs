using Abp.Application.Services;
using Abp.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VillageBoard.Carts
{
    public class CartAppService : CrudAppService<Cart, CartDto>
    {
        public CartAppService(IRepository<Cart, int> repository) : base(repository)
        {

        }
    }
}
