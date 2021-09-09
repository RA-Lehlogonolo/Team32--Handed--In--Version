using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VillageBoard.Student_Visitations
{
   public class StudentVisitationDto : EntityDto<int>
    {
        [AutoMapFrom(typeof(Studnet_Visitation))]

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

    }
}
