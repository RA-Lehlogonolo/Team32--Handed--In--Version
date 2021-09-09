using Abp.Application.Services;
using Abp.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VillageBoard.Payment_Types
{
    class PayementTypeAppService : CrudAppService<Payment_Type, PaymentTypeDto>
    {
        public PayementTypeAppService(IRepository<Payment_Type, int> repository) : base(repository)
        {

        }
    }
}
