using Abp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VillageBoard.Meal_Types;

namespace VillageBoard.Days
{
    public class Day : Entity<int>
    {

        [Required]
        [MaxLength(50)]
        public string Name { get; set; }

        //Fk References

        [ForeignKey(nameof(Meal_Type))]
        public int MealTypeID { get; set; }
        public Meal_Type Meal_Type { get; set; } 
    }
}
