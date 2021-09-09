using Abp.Application.Services;
using Abp.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VillageBoard.Suppliers
{
    public class SupplierAppService : CrudAppService<Supplier, SupplierDto>
    {
        public SupplierAppService(IRepository<Supplier, int> repository) : base(repository)
        {

        }
    }
}
