using Abp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VillageBoard.Residences;

namespace VillageBoard.Residence_Types
{
    public class Residence_Type : Entity<int>
    {
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }

        [Required]
        [MaxLength(150)]
        public string Description { get; set; }

        //Child Refernces 
        public IEnumerable<Residence> Residences { get; set; }


    }
}
