using Abp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VillageBoard.Visitation_Application_Statuses;
using Abp.Authorization.Users;

namespace VillageBoard.Student_Visitations
{
    public class Studnet_Visitation : Entity<int>
    {

        [Required]
        [MaxLength(50)]
        public string Host_Name { get; set; }

        [Required]
        [MaxLength(500)]
        public string Reason { get; set; }

        [Required]
        public DateTime Application_Date { get; set; }

        [Required]
        public DateTime Visit_Access { get; set; }

        [Required]
        public DateTime Start_Date { get; set; }

        [Required]
        public DateTime End_Date { get; set; }

        //FK References 

        [ForeignKey(nameof(Visitation_Applicaition_Status))]
        public int VisitationApplicaitionStatusId { get; set; }
        public Visitation_Applicaition_Status Visitation_Applicaition_Status { get; set; }

        [ForeignKey(nameof(Authorization.Users.User))]
        public long UserId { get; set; }
        public Authorization.Users.User User { get; set; }
    }
}
