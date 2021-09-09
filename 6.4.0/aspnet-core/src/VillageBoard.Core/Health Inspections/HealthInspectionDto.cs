using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VillageBoard.Health_Inspections
{
   public class HealthInspectionDto : EntityDto<int>
    {
        [AutoMapFrom(typeof(Health_Inspection))]

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

       

    }
}
