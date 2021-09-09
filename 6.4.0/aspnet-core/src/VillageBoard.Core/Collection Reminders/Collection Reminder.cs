using Abp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VillageBoard.Orders;

namespace VillageBoard.Collection_Reminders
{
    public class Collection_Reminder : Entity<int>
    {
        [Required]
        [MaxLength(500)]
        public string Decription { get; set; }

        //FK References

        [ForeignKey(nameof(Order))]
        public int OrderId { get; set; }
        public Order Order { get; set; }


    }
}
