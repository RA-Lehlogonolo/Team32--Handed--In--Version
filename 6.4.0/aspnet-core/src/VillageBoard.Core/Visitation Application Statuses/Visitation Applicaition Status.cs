using Abp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VillageBoard.Annoucements;
using VillageBoard.Student_Visitations;

namespace VillageBoard.Visitation_Application_Statuses
{
    public class Visitation_Applicaition_Status : Entity<int>
    {
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }
        [Required]
        [MaxLength(50)]
        public string Decsription { get; set; }

        //Child References

        public IEnumerable<Studnet_Visitation> Studnet_Visitations { get; set; }


    }
}
