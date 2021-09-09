using Abp.Application.Services;
using Abp.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VillageBoard.Product_Types
{
    public class ProductTypeAppService : CrudAppService<Product_Type, ProductTypeDto>
    {
        public ProductTypeAppService(IRepository<Product_Type, int> repository) : base(repository)
        {

        }
    }
}
