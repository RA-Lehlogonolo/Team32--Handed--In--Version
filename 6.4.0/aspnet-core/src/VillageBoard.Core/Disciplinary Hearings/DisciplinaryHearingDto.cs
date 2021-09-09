using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VillageBoard.Disciplinary_Hearings
{
    public class DisciplinaryHearingDto : EntityDto<int>
    {
        [AutoMapFrom(typeof(Disciplinary_Hearing))]

        [Required]
        [MaxLength(150)]
        public string Venue { get; set; }

        [Required]
        [MaxLength(500)]
        public string Decription { get; set; }

        [Required]
        public DateTime Date { get; set; }
    }
}
