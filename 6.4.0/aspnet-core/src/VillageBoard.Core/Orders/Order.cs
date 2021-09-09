using Abp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VillageBoard.Order_Statuses;
using Abp.Authorization.Users;
using System.ComponentModel.DataAnnotations.Schema;
using VillageBoard.Collection_Reminders;

namespace VillageBoard.Orders
{
    public class Order : Entity<int>
    {
        [Required]
        [MaxLength(10)]
        public string Number { get; set; }

        [Required]
        [MaxLength(500)]
        public string Decription { get; set; }

        [Required]
        public DateTime Date { get; set; }

        //Child References

        public IEnumerable<Collection_Reminder> Collection_Reminders { get; set; }


        //Fk References

        [ForeignKey(nameof(Order_Status))]
        public int OrderStatusId { get; set; }
        public Order_Status Order_Status { get; set; }

        [ForeignKey(nameof(Authorization.Users.User))]
        public long UserId { get; set; }
        public Authorization.Users.User User { get; set; }

        
    }
}
