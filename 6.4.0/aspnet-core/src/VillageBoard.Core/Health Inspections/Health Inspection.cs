using Abp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VillageBoard.Health_Inspection_Types;
using VillageBoard.Health_Inspection_Statuses;
using Abp.Authorization.Users;
using System.ComponentModel.DataAnnotations.Schema;

namespace VillageBoard.Health_Inspections
{
   public  class Health_Inspection : Entity<int>
    {
        [Required]
        [MaxLength(50)]
        public string Travelled_to_high_risk_country { get; set; }

        [Required]
        [MaxLength(50)]
        public string Had_Contact_With_Anyone_with_COVID { get; set; }

        [Required]
        [MaxLength(50)]
        public string Travelled_to_different_provice { get; set; }

        [Required]
        [MaxLength(50)]
        public string Fever { get; set; }

        [Required]
        [MaxLength(50)]
        public string Caugh { get; set; }

        [Required]
        [MaxLength(50)]
        public string Red_Eyes { get; set; }

        [Required]
        [MaxLength(50)]
        public string Difficaulty_Breathing { get; set; }

        [Required]
        [MaxLength(50)]
        public string Sore_Throat { get; set; }

        [Required]
        [MaxLength(50)]
        public string Result { get; set; }


        [Required]
        public DateTime Date { get; set; }

        //Fk References

        [ForeignKey(nameof(Health_Inpsection_Type))]
        public int HealthInpsectionTypeId { get; set; }
        public Health_Inpsection_Type Health_Inpsection_Type { get; set; }

        [ForeignKey(nameof(Health_Inspection_Status))]
        public int HealthInspectionStatusId { get; set; }
        public Health_Inspection_Status Health_Inspection_Status { get; set; }

        [ForeignKey(nameof(Authorization.Users.User))]
        public long UserId { get; set; }
        public Authorization.Users.User User { get; set; }

    }
}
