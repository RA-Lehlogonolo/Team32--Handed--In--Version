using Abp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VillageBoard.Carts
{
    public class Cart : Entity<int>
    {
        [Required]
        public decimal Total { get; set; }

        [ForeignKey(nameof(Authorization.Users.User))]
        public long UserId { get; set; }
        public Authorization.Users.User User { get; set; }
    }
}
