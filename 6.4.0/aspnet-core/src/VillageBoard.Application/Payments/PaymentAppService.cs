using Abp.Application.Services;
using Abp.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VillageBoard.Payments
{
    public class PaymentAppService : CrudAppService<Payment, PaymentDto>
    {
        public PaymentAppService(IRepository<Payment, int> repository) : base(repository)
        {

        }
    }
}
