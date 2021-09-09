using Abp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VillageBoard.Meals
{
    public class Meal : Entity<int>
    {
        [Required]

        [MaxLength(50)]
        public String Name { get; set; }
    }
}
