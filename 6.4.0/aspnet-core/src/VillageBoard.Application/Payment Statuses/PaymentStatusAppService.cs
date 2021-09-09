using Abp.Application.Services;
using Abp.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VillageBoard.Payment_Statuses
{
    class PaymentStatusAppService : CrudAppService<Payment_Status, PaymentStatusDto>
    {
        public PaymentStatusAppService(IRepository<Payment_Status, int> repository) : base(repository)
        {

        }
    }
}
