using Abp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VillageBoard.Health_Inspections;

namespace VillageBoard.Health_Inspection_Types
{
    public class Health_Inpsection_Type : Entity<int>
    {
        [Required]
        [MaxLength(50)]
        public string Description { get; set; }

        //Child References
        public IEnumerable<Health_Inspection> Health_Inspections { get; set; }
    }
}
