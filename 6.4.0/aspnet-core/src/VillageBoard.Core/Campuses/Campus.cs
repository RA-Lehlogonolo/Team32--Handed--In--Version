using Abp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VillageBoard.Residences;

namespace VillageBoard.Campuses
{
    public class Campus : Entity<int>
    {
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }


        //Child References
        public IEnumerable<Residence> Residences { get; set; }

    }
}
