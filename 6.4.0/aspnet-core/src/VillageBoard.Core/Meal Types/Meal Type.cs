using Abp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VillageBoard.Days;

namespace VillageBoard.Meal_Types
{
    public class Meal_Type : Entity<int>
    {
        [Required]
        public string Name { get; set; }

        //Child references
        public IEnumerable<Day> Days { get; set; }

    }
}
