using Abp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VillageBoard.Dates
{
    public class Date : Entity<int>
    {
        [Required]
        public DateTime Set_Date { get; set; }
    }
}
