using Abp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VillageBoard.Payment_Statuses;
using VillageBoard.Payment_Types;

namespace VillageBoard.Payments
{
    public class Payment : Entity<int>
    {
        

        [Required]
        public decimal Amount { get; set; }

        [Required]
        public DateTime Date { get; set; }


        //Fk References

        [ForeignKey(nameof(Payment_Status))]
        public int PaymentStatusId { get; set; }
        public Payment_Status Payment_Status { get; set; }

        [ForeignKey(nameof(Payment_Type))]
        public int PaymentTypeId { get; set; }
        public Payment_Type Payment_Type { get; set; }

    }
}
